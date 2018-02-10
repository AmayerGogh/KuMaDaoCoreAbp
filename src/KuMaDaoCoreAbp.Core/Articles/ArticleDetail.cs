using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace KuMaDaoCoreAbp.Articles
{
    public class ArticleDetail : Entity<long>
    {
        public virtual long ArticleId {get;set;}
        public virtual string Body { get; set; }

        public virtual int Type { get; set; }

        public ArticleDetail()
        {

        }
        public ArticleDetail(long _ArticleId)
        {
            ArticleId = _ArticleId;
            Type = (int)ArticleDetailType.html;
        }



    }

    public enum ArticleDetailType
    {
        html=1,
        md =2
    }
}
