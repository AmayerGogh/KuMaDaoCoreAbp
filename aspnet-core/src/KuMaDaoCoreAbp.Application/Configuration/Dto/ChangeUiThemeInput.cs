using System.ComponentModel.DataAnnotations;

namespace KuMaDaoCoreAbp.Configuration.Dto
{
    /// <summary></summary>
    public class ChangeUiThemeInput
    {
        /// <summary></summary>
        [Required]
        [StringLength(32)]

        public string Theme { get; set; }
    }
}
