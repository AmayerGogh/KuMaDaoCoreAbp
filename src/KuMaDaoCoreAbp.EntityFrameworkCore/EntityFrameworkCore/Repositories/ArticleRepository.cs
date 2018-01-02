using Abp.EntityFrameworkCore;
using KuMaDaoCoreAbp.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.EntityFrameworkCore.Repositories
{
    public class ArticleRepository : KuMaDaoCoreAbpRepositoryBase<Article,long>, IArticleRepository
    {
        public ArticleRepository(IDbContextProvider<KuMaDaoCoreAbpDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

       
        public List<Article> TestRepository(long id)
        {
            throw new NotImplementedException();
        }
    }
}
