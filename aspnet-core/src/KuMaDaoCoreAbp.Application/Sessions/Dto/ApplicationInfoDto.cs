using System;
using System.Collections.Generic;

namespace KuMaDaoCoreAbp.Sessions.Dto
{
    /// <summary></summary>
    public class ApplicationInfoDto
    {
        /// <summary></summary>
        public string Version { get; set; }
        /// <summary></summary>
        public DateTime ReleaseDate { get; set; }
        /// <summary></summary>
        public Dictionary<string, bool> Features { get; set; }
    }
}
