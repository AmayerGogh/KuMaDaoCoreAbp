using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KuMaDaoCoreAbp.Dto
{
    public class FileDto
    {
        [Required]
        public string FileName { get; set; }

        [Required]
        public string FileType { get; set; }

        [Required]
        public string FileToken { get; set; }

        public FileDto()
        {

        }

        public FileDto(string fileName, string fileType)
        {
            FileName = fileName;
            FileType = fileType;
            FileToken = Guid.NewGuid().ToString("N");
        }
    }
}
