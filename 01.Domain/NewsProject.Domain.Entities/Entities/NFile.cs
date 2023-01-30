using NewsProject.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsProject.Domain.Entities.Entities
{
   public  class NFile:BaseEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public EnumFileType FileType { get; set; }
        public string Path { get; set; }
        public int DownloadCount { get; set; }
        public int FileSize { get; set; }
    }
}
