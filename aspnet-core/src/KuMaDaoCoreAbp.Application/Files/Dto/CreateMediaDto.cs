using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Files.Dto
{
    /// <summary></summary>
    public class CreateMediaDto
    {
        /// <summary></summary>
        public IFormFile File{get;set;}
    }
}
