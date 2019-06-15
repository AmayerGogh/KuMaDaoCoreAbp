using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KuMaDaoCoreAbp.Users.Dto
{
    /// <summary></summary>
    public class ChangeUserLanguageDto
    {
        /// <summary></summary>
        [Required]
        public string LanguageName { get; set; }
    }
}
