using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTests
{
    class Program
    {
        static void Main(string[] args)
        {
            test();
        }

        void ParallelMethod()
        {
            ParallelLoopResult result = Parallel.For(0, 10, async i =>
            {
                Console.WriteLine("{0},task:{1},thread:{2}", i, Task.CurrentId, Thread.CurrentThread.ManagedThreadId);

                await Task.Delay(10);
                Console.WriteLine("{0},task:{1},thread:{2}", i, Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
            });
            Console.WriteLine("Is Compoleted:{0}", result.IsCompleted);
            Console.ReadKey();
        }

        private static object taskMethodLock = new object();
        static void TaskMethod(object title)
        {
            lock (taskMethodLock)
            {
                Console.WriteLine(title);
                Console.WriteLine("TaskId:{0},thread:{1}",
                    Task.CurrentId == null ? "no task" : Task.CurrentId.ToString(),
                    Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("Is pooled thread:{0}", Thread.CurrentThread.IsThreadPoolThread);
                Console.WriteLine("Is background thread:{0}", Thread.CurrentThread.IsBackground);
                Console.WriteLine();
                Console.ReadKey();
            }
        }

        static void TaskUsingThreadPool()
        {
            var tf = new TaskFactory();
            Task t1 = tf.StartNew(TaskMethod, "using a task factory");
            Task t2 = Task.Factory.StartNew(TaskMethod, "factory via task");
            var t3 = new Task(TaskMethod, "using a task constructor and start");
            t3.Start();
            Task t4 = Task.Run(() => TaskMethod("using run method"));
        }

        static void test()
        {
            List<string> list = new List<string>() {"lixin", "wangbing"};
            var result = list.Select(a => a == "lixin");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
