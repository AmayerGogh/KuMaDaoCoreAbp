using Amayer.Express._pingins;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
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

    /// <summary>
    /// 用以产生非重复标识
    /// 先获取单例
    /// </summary>
    public class TimestampID
    {
        int _sequence; //计数从零开始
        private static TimestampID _timerId;
        DateTime _lastTime;
        public static TimestampID GetInstance()
        {
            if (_timerId == null)
            {
                Interlocked.CompareExchange(ref _timerId, new TimestampID(), null);
            }
            return _timerId;
        }
        public string Next(Func<DateTime, string> action)
        {
            lock (this)
            {
                if (_sequence > 99)
                {
                    Thread.Sleep(1);
                }
                var this_time = DateTime.Now;
                if (this_time == _lastTime)
                {
                    _sequence++;
                }
                else
                {
                    _sequence = 0;
                }
                _lastTime = this_time;
            }
            return Fill($"{action(_lastTime)}{Fill(_sequence.ToString(), 2)}", 5);
        }

        string Fill(string temp, int totalW)
        {
            if (temp.Length == totalW)
            {
                return temp;
            }
            var chars = new List<char>();
            for (int i = 0; i < totalW - temp.Length; i++)
            {
                chars.Add('0');
            }
            return new string(chars.ToArray()) + temp;
        }

    }
}
