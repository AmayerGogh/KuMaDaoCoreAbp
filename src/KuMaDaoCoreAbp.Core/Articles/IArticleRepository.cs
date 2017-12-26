using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Articles
{
   public interface IArticleRepository:IRepository<Article,long>
    {
        List<Article> TestRepository(long id);
    }
}
