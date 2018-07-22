using KuMaDaoCoreAbp.Files.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace KuMaDaoCoreAbp.Files
{
    class FileService
    {




        public  async void Create([FromForm]CreateMediaDto input)
        {
            using (var fileStream = new FileStream($"{"dir"}\\{"filename"}.{"ext"}", FileMode.Create))
            {
               await input.File.CopyToAsync(fileStream);
            }
        }
    }
}
