using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KuMaDaoCoreAbp.Articles
{

    public class Article : CreationAuditedEntity<long>
    {

        [Required]
        [MaxLength(20)]
        public virtual string Title { get; set; }


        public virtual string Body { get; set; }
        public virtual int CategoryId { get; set; }
    }

}
