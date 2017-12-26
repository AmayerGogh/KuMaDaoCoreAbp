using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Articles
{
   public interface IArticleManager : IDomainService
    {
        void TestManager(Article article);
    }
}
