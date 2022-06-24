using System;
using System.Threading;
using System.Threading.Tasks;

namespace 六月二二
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 一
            // int n = int.Parse(Console.ReadLine());
            // PrintNumbersInRange(0,10);
            // var task = Task.Run(()=>
            //PrintNumbersInRange(10,20));
            // Console.WriteLine("Done.");
            // task.wait();
            #endregion

            #region 二
            Console.WriteLine("Hello World!");

            //异步执行，同时执行多个线程
            ThreadStart ts = () => ds("btn3");
            Thread th = new Thread(ts);
            th.Start();

            //使用ThreadPool类比Thread类创建线程简单的多
            //线程池
            //ThreadPool.QueueUserWorkItem(t => ds("btn4"));

            //task run
            Task.Run(() => ds("task1"));
            //TaskFactory 
            TaskFactory tf = Task.Factory;
            tf.StartNew(() => ds("task3"));
            //TaskStart
            new Task(() => ds("task5")).Start();

            //直接使用会造成阻塞，导致之后的进程无法执行
            //ds("btn");

            Console.WriteLine("aaaaaa");
            Console.ReadLine();

            #endregion

            Console.WriteLine("hello world");


        }
        private static void ds(string name)
        {
            Console.WriteLine($"ds {name} start 启动加载 ");
            long r = 0;
            for (int i = 0; i < 1000000; i++)
            {
                r++;
            }
            Thread.Sleep(2000);
            Console.WriteLine($"ds {name} fin 启动加载 ");
        }


    }
}
