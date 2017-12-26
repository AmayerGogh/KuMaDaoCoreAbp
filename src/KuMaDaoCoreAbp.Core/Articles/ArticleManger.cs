using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Articles
{
   public  class ArticleManager: IArticleManager
    {

        private readonly IRepository<Article, long> _articleRepository;

        public ArticleManager(IRepository<Article, long> articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void TestManager(Article article)
        {
            throw new NotImplementedException();
        }

        //领域代码
    }
}
