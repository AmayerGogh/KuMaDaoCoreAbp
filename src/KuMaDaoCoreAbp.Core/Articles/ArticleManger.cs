using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Articles
{
   public  class ArticleManager: IDomainService
    {

        private readonly IRepository<Article, long> _articleRepository;

        public ArticleManager(IRepository<Article, long> articleRepository)
        {
            _articleRepository = articleRepository;
        }

        //领域代码
    }
}
