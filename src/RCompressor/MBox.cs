using System.Windows.Forms;

namespace RCompressor
{
    public class MBox
    {
        public static void Warn(string message)
        {
            MessageBox.Show(message, "RCompressor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
