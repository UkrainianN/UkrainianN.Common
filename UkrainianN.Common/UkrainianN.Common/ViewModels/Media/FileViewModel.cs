using System;
namespace UkrainianN.Common.ViewModels.Media
{
    public class FileViewModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string OriginalName { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Extension { get; set; }
        public bool IsDanger { get; set; }
        public string MD5CheckSum { get; set; }
        public FileSizeViewModel Size { get; set; }
        public FileType Type { get; set; }
    }
}