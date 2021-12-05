namespace Lab1
{
    public class FileDataReader : IGetStringReader
    {
        public string GetString(string useDefaultPath = "")
        {
            string filePath = string.Empty;
            if (string.IsNullOrEmpty(useDefaultPath))
            {
                string fileNameWithoutFileEnding = "indata";
                filePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + $"\\{fileNameWithoutFileEnding}.txt");
            }
            else filePath = useDefaultPath;

            if (!File.Exists(filePath))
                throw new NullReferenceException();

            string fileContent;

            try
            {
                fileContent = File.ReadLines(filePath).First();
            }
            catch (Exception)
            {
                throw new NullReferenceException();
            }

            return fileContent;
        }
    }
}
