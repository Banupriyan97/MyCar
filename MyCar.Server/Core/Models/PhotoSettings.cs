namespace MyCar.Server.Core.Models
{
    public class PhotoSettings
    {
        public int MaxFileSize { get; set; }
        public string[] AcceptedFileTypes { get; set; }

        public bool IsSupported(string fileName)
        {
            return AcceptedFileTypes.Any(type => type == Path.GetExtension(fileName).ToLower());
        }
    }
}
