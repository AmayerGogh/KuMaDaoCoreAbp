using Amayer.Express._pingins;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Amayer.Express
{
    public static class Express
    {

        /// <summary>
        /// 由表达式树集合构建表达式树
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static async Task<Expression<Func<T, bool>>> BulidExpressionAsync<T>(List<Expression<Func<T, bool>>> list)
        {
           Expression<Func<T, bool>> lam = null;
           await Task.Run(() =>
            {
                
                list.Add(m => 1 == 1); //至少也要有一个条件
                foreach (var expression in list)
                {
                    lam = lam == null ? expression : lam.And(expression);
                }
              
            });
            return lam;
        }
    }
}
