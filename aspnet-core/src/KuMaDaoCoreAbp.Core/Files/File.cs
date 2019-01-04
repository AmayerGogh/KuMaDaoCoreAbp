using Abp.Domain.Entities;
using KuMaDaoCoreAbp.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Files
{
    public class File : Entity<long>
    {
        public string Name { get; set; }
        public decimal Size { get; set; }

        public decimal Extension { get; set; }

        public long CategoryId { get; set; }
        public int Type { get; set; }
        /// <summary>
        /// 根据 FileStatus 隶属哪个分类  ArticleId
        /// </summary>
        public long? ParamId { get; set; }
        public int Status { get; set; }
        public int FileLocation { get; set; }
        public DateTime CreationTime { get; set; }
    }

    public enum EnumFileType
    {

        image = 1,
        video = 2,
        doc = 3,
        other = 4,
    }
    public enum EnumFileStatus
    {
        未显示 = 0,
        文件 = 1,
        文件预览 = 2,
        文章内容 = 3,
        文章封面 = 4,
        文章附件 = 5
    }
    public enum EnumFileLocation
    {
        local = 1,
        qiniu = 2
    }
}
