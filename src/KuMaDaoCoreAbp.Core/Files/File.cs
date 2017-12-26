using Abp.Domain.Entities;
using KuMaDaoCoreAbp.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Files
{
    public  class File:Entity<long>
    {
        public string Name { get; set; }
        public decimal Size { get; set; }
        
        public decimal Extension { get; set; }

        public long CategoryId { get; set; }
        public int Type { get; set; }

        /// <summary>
        /// 预览id
        /// </summary>
        public long  PreviewFileId { get; set; }

        public int Status { get; set; }
    }

    public enum FileType
    {

        image=1,
        video=2,
        docu=3,
        other=4,
        preview=5
    }
    public enum FileStatus
    {
        未显示=0,
        默认 =1,
        Detail内部=2
    }
}
