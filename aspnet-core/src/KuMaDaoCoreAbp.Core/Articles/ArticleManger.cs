using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Amayer.Express;
using KuMaDaoCoreAbp.Web;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
            
        }

        //领域代码


        public List<Expression<Func<Article,bool>>> GetListAsync(BsTableRequestModel param)
        {
            //var expressionList = new List<Expression<Func<Article, bool>>>();
            var lamList = LambdaHelper.GetExpressionList<Article>();
            if (!string.IsNullOrWhiteSpace(param.search))
            {
                lamList.Add(m => m.Title == param.search);
            }
            string s = null ;
            try
            {
                if (param.searches!=null)
                {
                    if (param.searches.ContainsKey("id"))
                    {

                    }
                    if (param.searches.ContainsKey("categoryId"))
                    {

                    }
                }
              
            }
            catch (Exception ex)
            {

            
            }
           
            return lamList;
        }
    }
}
