using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Specifications;
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
            throw new NotImplementedException();
        }

        //领域代码


        public async Task<Expression<Func<Article,bool>>> GetListAsync(BsTableRequestModel param)
        {
            var expressionList = new List<Expression<Func<Article, bool>>>();
            if (!string.IsNullOrWhiteSpace(param.search))
            {
                expressionList.Add(m => m.Title.Contains(param.search));
            }
            if (param.searches!=null)
            {
                if (param.searches.ContainsKey("categoryId"))
                {
                    int cate =-1;
                    Int32.TryParse(param.searches["categoryId"], out cate);
                    if (cate!=-1&&cate!=0)
                    {
                        expressionList.Add(m => m.CategoryId ==cate );
                    }                    
                }
            }
           return await Amayer.Express.Express.BulidExpressionAsync(expressionList);
        }
        /// <summary>
        /// 规约
        /// </summary>
        /// <param name="specification"></param>
        /// <returns></returns>
        //用例
        //GetList(new IsDeleteSpecification().And(new CategorySelectSpecification(1)));
        //public int GetList(ISpecification<Article> specification)
        //{
        //    //specification.
        //    _articleRepository.GetAllList(specification.ToExpression());
        //    return 0;            
        //}
    }
    public class IsDeleteSpecification: Specification<Article>
    {
        public override Expression<Func<Article, bool>> ToExpression()
        {
            return c => c.IsDeleted == true;
        }       
    }
    public class CategorySelectSpecification : Specification<Article>
    {
        public override Expression<Func<Article, bool>> ToExpression()
        {
            return c => c.CategoryId == _categoryId;
        }
        long _categoryId { get;  }
        public CategorySelectSpecification(long categoryId)
        {
            this._categoryId = categoryId;
        }

    }
}
