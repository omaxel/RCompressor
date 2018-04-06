using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace RCompressor
{
    public static class Compressor
    {       
        private static Regex rgxRazorComment = new Regex(@"(?s)@\*.*?\*@", RegexOptions.Compiled);
        private static Regex rgxCSharpMultilineComment = new Regex(@"(?s)\/\*.*?\*\/", RegexOptions.Compiled);

        private static Regex rgxCSharpComment = new Regex(@"(.*)\/\/.*", RegexOptions.Compiled);
        private static Regex rgxNewLine = new Regex("\r\n|\r|\n", RegexOptions.Compiled);

        public static void Compress(string filePath)
        {
            var content = File.ReadAllText(filePath);

            //(?s) -> il punto include anche le terminazioni di riga
            //.*? -> Permette di catturare tutto fino quando non si trova */

            content = rgxRazorComment.Replace(content, "");
            content = rgxCSharpMultilineComment.Replace(content, "");

            var lines = rgxNewLine.Split(content);

            var output = new StringBuilder();

            foreach (var line in lines)
            {
                //Ignoring empty and white spaced lines
                if (string.IsNullOrWhiteSpace(line)) continue;

                var trimmedLine = line.TrimStart(new char[] { ' ', '\r', '\n' });

                //Single line comment starting at the beginning of the line
                if (trimmedLine.StartsWith("//")) continue;

                //Removing single line C# comments that aren't at the beginning of the line
                trimmedLine = rgxCSharpComment.Replace(trimmedLine, x =>
                {
                    var beforeComment = x.Groups[1].Value;

                    //A double forward slash could be part of a URL
                    if (beforeComment.EndsWith(":")) return x.Value;

                    return beforeComment;
                });

                output.AppendLine(trimmedLine);
            }

            //Removing new lines at the end of the file
            var outputStr = output.ToString().Trim(new char[] { ' ', '\r', '\n' });

            File.WriteAllText(filePath, outputStr, Encoding.UTF8);
        }
    }
}
    