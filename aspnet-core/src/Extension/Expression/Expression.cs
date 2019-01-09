﻿using Amayer.Express._pingins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Amayer.Express
{
    public static class LambdaHelper
    {

        /// <summary>
        /// 由表达式树集合构建表达式树
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> BulidExpression<T>(List<Expression<Func<T, bool>>> list)
        {
            Expression<Func<T, bool>> lam = null;
            list.Add(m => 1 == 1); //至少也要有一个条件
            foreach (var expression in list)
            {
                if (lam == null)
                {
                    lam = expression;
                }
                else
                {
                    lam = lam.And(expression);
                }
            }
            return lam;
        }
        public static List<Expression<Func<T, bool>>> GetExpressionList<T>()
        {
            return new List<Expression<Func<T, bool>>>();
        }
        public static IEnumerable<TSource> WhereParam<TSource>(this IEnumerable<TSource> sources, List<Expression<Func<TSource, bool>>> list)
        {
            Expression<Func<TSource, bool>> lam = null;
            if (list.Count == 0)
            {
                return sources;
            }
            foreach (var expression in list)
            {
                if (lam == null)
                {
                    lam = expression;
                }
                else
                {
                    lam = lam.And(expression);
                }
            }
            return sources.Where(lam.Compile());
        }
        public static async Task<IEnumerable<TSource>> WhereParamAsync<TSource>(this IQueryable<TSource> sources, List<Expression<Func<TSource, bool>>> list)
        {
            Expression<Func<TSource, bool>> lam = null;
            if (list.Count == 0)
            {
                return sources;
            }
            await Task.Run(() =>
             {
                 foreach (var expression in list)
                 {
                     if (lam == null)
                     {
                         lam = expression;
                     }
                     else
                     {
                         lam = lam.And(expression);
                     }
                 }
             });
            return sources.Where(lam);
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
