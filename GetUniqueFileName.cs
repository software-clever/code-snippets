namespace code_snippets
{
    public partial class Snippets
    {
        /// <summary>
        /// Generates a unique file name for the given path by appending a timestamp if the file already exists.
        /// </summary>
        /// <param name="dest">The original file path.</param>
        /// <returns>A unique file name path. If the file already exists, a timestamp is appended to ensure uniqueness.</returns>
        /// <example>
        /// This example shows how to call the <see cref="GetUniqueFileName"/> method.
        /// <code>
        /// string originalPath = "C:\\SampleFiles\\example.txt";
        /// string uniquePath = GetUniqueFileName(originalPath);
        /// Console.WriteLine(uniquePath);
        /// </code>
        /// If "example.txt" exists, the output might be "C:\\SampleFiles\\example_20230415123000.txt", assuming the current date and time is April 15, 2023, 12:30:00.
        /// </example>
        private static string GetUniqueFileName(string dest)
        {
            if (File.Exists(dest))
            {
                var dir = Path.GetDirectoryName(dest);
                var f = Path.GetFileNameWithoutExtension(dest) + "_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                var ext = Path.GetExtension(dest);
                dest = Path.Combine(dir, f + ext);
            }
            return dest;
        }
    }
}
