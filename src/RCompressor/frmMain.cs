using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RCompressor
{
    public partial class frmMain : Form
    {
        private bool cmdUsage = false;

        class ProcessParams
        {
            public string[] Input { get; set; }
            public bool ScanSubfolders { get; set; }
        }

        class ProcessResult
        {
            public bool Success { get => string.IsNullOrEmpty(Error); }
            public string Error { get; set; }
        }

        public frmMain()
        {
            InitializeComponent();

            var args = Environment.GetCommandLineArgs();

            if (args.Length > 1)
            {
                cmdUsage = true;

                //Remove the first parameter which is the exe path
                args = args.Skip(1).ToArray();

                var scanSubfolders = args.Contains("-subfolders");

                if (scanSubfolders)
                {
                    args = args.Where(x => x != "-subfolders").ToArray();
                }


                bkProcessFiles.RunWorkerAsync(new ProcessParams() { Input = args, ScanSubfolders = scanSubfolders });
            }
            else
            {
                Visible = true;
            }
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!IsHandleCreated)
            {
                CreateHandle();
                value = false;
            }
            base.SetVisibleCore(value);
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            var input = txtInput.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                MBox.Warn("No input specified");
                return;
            }

            btnCompress.Enabled = false;
            StatusNormal("Starting processing files...");
            bkProcessFiles.RunWorkerAsync(new ProcessParams() { Input = input.Split(Environment.NewLine.ToCharArray()), ScanSubfolders = ckScanSubfolders.Checked });
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            btnCompress.Enabled = !string.IsNullOrWhiteSpace(txtInput.Text);
        }

        private void bkProcessFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            var processParams = e.Argument as ProcessParams;

            var paths = processParams.Input;

            var result = new ProcessResult();

            var filesToProcess = new List<string>();

            bkProcessFiles.ReportProgress(0, "Validating paths...");

            foreach (var path in paths)
            {
                if (Directory.Exists(path))
                {
                    filesToProcess.AddRange(Directory.GetFiles(path, "*.cshtml", processParams.ScanSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
                }
                else if (File.Exists(path) && path.ToLower().EndsWith(".cshtml"))
                {
                    filesToProcess.Add(path);
                }
                else
                {
                    result.Error = $"Invalid path '{path}'";
                }
            }

            filesToProcess = filesToProcess.Distinct().ToList();

            int total = filesToProcess.Count;
            int i = 1;

            foreach (var file in filesToProcess)
            {
                bkProcessFiles.ReportProgress(i * 100 / total, $"Processing file {i} of {total}");
                Compressor.Compress(file);
            }

            e.Result = result;
        }

        private void bkProcessFiles_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            StatusNormal(e.UserState.ToString());
        }

        private void bkProcessFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var result = e.Result as ProcessResult;

            if (cmdUsage)
            {
                Environment.Exit(0);
            }

            btnCompress.Enabled = true;

            if (result.Success)
            {
                StatusSuccess("Complete");
            }
            else
            {
                StatusError(result.Error);
            }
        }

        private void StatusError(string message)
        {
            txtStatus.ForeColor = Color.Red;
            txtStatus.Text = message;
        }

        private void StatusSuccess(string message)
        {
            txtStatus.ForeColor = Color.Green;
            txtStatus.Text = message;
        }

        private void StatusNormal(string message)
        {
            txtStatus.ForeColor = Color.Black;
            txtStatus.Text = message;
        }

        private void lblFooter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/OmarMuscatello/");
        }       
    }
}
