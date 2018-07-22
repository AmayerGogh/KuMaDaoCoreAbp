using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace ConsoleTest
{
    public class ThreadTest
    {
        public ThreadTest()
        {
            //Test2();
            //Test3();
            Test4();
        }

        //https://www.cnblogs.com/liuqiwang/p/8413667.html
        public static void Test()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Console.WriteLine($"开始执行了,{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ffff")},,,,{Thread.CurrentThread.ManagedThreadId}");
            Action<string> act = x =>{Console.WriteLine(x);};
            for (int i = 0; i < 5; i++)
            {
                var name = $"{i}";
                act.BeginInvoke(name, null, null); 
            }
            watch.Stop();
            Console.WriteLine($"结束执行了,{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ffff")},,,,{watch.ElapsedMilliseconds}");
        }


        //运行结果
        //Thread多线程开始了
        //等待中.....
        //Async 2
        //Async 1
        //Async 3
        //Async 4
        //Async 0
        public static void Test2()
        {
            //Thread
            //Thread默认属于前台线程，启动后必须完成
            //Thread有很多Api，但大多数都已经不用了
            Console.WriteLine("Thread多线程开始了");
            Stopwatch watch = new Stopwatch();
            watch.Start();
            //线程容器
            List<Thread> list = new List<Thread>();
            for (int i = 0; i < 5; i++)
            {
                //int ThreadId = Thread.CurrentThread.ManagedThreadId;//获取当前线程ID
                string name = $"Async {i}";
                ThreadStart start1 = () =>
                {
                    Console.WriteLine(name);
                    throw new Exception("错误");
                };
                Thread thread =  new Thread(start1);
                thread.IsBackground = true;//设置为后台线程，关闭后立即退出
                thread.Start();
                list.Add(thread);
                //thread.Suspend();//暂停，已经不用了
                //thread.Resume();//恢复，已经不用了
                //thread.Abort();//销毁线程
                //停止线程靠的不是外部力量，而是线程自身，外部修改信号量，线程检测信号量
            }
            //判断当前线程状态，来做线程等待
            //while (list.(t => t.ThreadState != System.Threading.ThreadState.Stopped) > 0)
            //{
                Console.WriteLine("等待中.....");
                Thread.Sleep(500);
            //}
            //统计正确全部耗时，通过join来做线程等待
            foreach (var item in list)
            {
                item.Join();//线程等待，表示把thread线程任务join到当前线程，也就是当前线程等着thread任务完成
                            //等待完成后统计时间
            }
            watch.Stop();
        }


        /// <summary>
        /// 回调封装，无返回值
        /// </summary>
        /// <param name="start"></param>
        /// <param name="callback"></param>
        private static void ThreadWithCallback(ThreadStart start, Action callback)
        {
            ThreadStart nweStart = () =>
            {
                start.Invoke();
                callback.Invoke();
            };
            Thread thread = new Thread(nweStart);
            thread.Start();
        }   
    

        public static void Test3()
        {
            ThreadWithCallback(() =>
            {
                Console.WriteLine("回掉函数");          
            }, () =>
            {
                Console.WriteLine("正常执行");
            });           
        }
        private static Func<T>  ThreadWithReturn<T>(Func<T> func)
        {
            T t = default(T);
            //ThreadStart本身也是一个委托
            ThreadStart start = () =>
            {
                t = func.Invoke();
            };
            //开启一个子线程
            Thread thread = new Thread(start);
            thread.Start();
            //返回一个委托，因为委托本身是不执行的，所以这里返回出去的是还没有执行的委托
            //等在获取结果的地方，调用该委托
            return () =>
            {
                //只是判断状态的方法
                while (thread.ThreadState != System.Threading.ThreadState.Stopped)
                {
                    Thread.Sleep(500);
                }
                //使用线程等待
                //thread.Join();
                //以上两种都可以
                return t;
            };
        }


        //正在执行。。。
        //Else.....
        //Else.....
        //Else.....
        //执行结束。。。
        //有参数回调函数的回调结果：2018
        static void Test4()
        {
            Func<int> func = () =>
            {
                Console.WriteLine("正在执行。。。");
                Thread.Sleep(10000);
                Console.WriteLine("执行结束。。。");
                return DateTime.Now.Year;
            };
            Func<int> newfunc = ThreadWithReturn(func);
            //这里为了方便测试，只管感受回调的执行原理
            Console.WriteLine("Else.....");
            Thread.Sleep(100);
            Console.WriteLine("Else.....");
            Thread.Sleep(100);
            Console.WriteLine("Else.....");
            //执行回调函数里return的委托获取结果
            //newfunc.Invoke();
            Console.WriteLine($"有参数回调函数的回调结果：{newfunc.Invoke()}");
        }

    }
}
