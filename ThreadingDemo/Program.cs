using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parallel For
            //Console.WriteLine("==Parallel For==");
            //ParallelLoopResult result = Parallel.For(0, 10, i =>
            //{
            //    string start = DateTime.Now.ToString("mm:ss.ms");
            //    Thread.CurrentThread.Priority = ThreadPriority.Lowest;
            //    //Thread.Sleep(10);
            //    string End = DateTime.Now.ToString("mm:ss.ms");
            //    Console.WriteLine("id:{0},task:{1},ThreadPriority:{2},Thread:{3},Start:{4},End:{5}",
            //       i, Task.CurrentId, Thread.CurrentThread.Priority, Thread.CurrentThread.ManagedThreadId, start, End);
            //    //thread after sleep is same if use Task.Delay(10) it differ
            //});
            //Console.WriteLine("Result Completed " + result.IsCompleted); 
            #endregion

            #region ParallelLoopState
            //Console.WriteLine("==ParallelLoopState==");
            //ParallelLoopResult result = Parallel.For(10, 40, async (int i, ParallelLoopState psl) =>
            //{
            //    Console.WriteLine("{0},task:{1},thread:{2}", i, Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
            //    await Task.Delay(10);
            //    if (i > 15) psl.Break();
            //});
            //Console.WriteLine("Lowest Break Iteration" + result.LowestBreakIteration);
            //Parallel.For(0, 20, () =>
            //{
            //    Console.WriteLine("Init Thread {0} ,task {1}", Thread.CurrentThread.ManagedThreadId, Task.CurrentId);
            //    return string.Format("t{0}", Thread.CurrentThread.ManagedThreadId);
            //}, (i, pls, str1) =>
            //{
            //    Console.WriteLine("Body i{0},str1{1},thread{2},task{3}", i, str1, Thread.CurrentThread.ManagedThreadId, Task.CurrentId);
            //    Thread.Sleep(10);
            //    return string.Format("i{0}", i);
            //}, (str1) =>
            //{
            //    Console.WriteLine("finally {0}", str1);
            //});
            #endregion

            #region Parallel for each method

            //Console.WriteLine("==Parallel for each method");
            //int[] data = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //Parallel.ForEach<int>(data, (s, pls, l) =>
            //{
            //    Console.WriteLine("{0} -- {1},pls{2}", s, l, pls);
            //});

            #endregion

            #region Parallel Invoke

            //Console.WriteLine("==Parallel Invoke==");
            //Parallel.Invoke(foo, bar, foo1, bar1, bar2, foo2, bar, foo1, bar1, bar2, foo2, bar, foo1, bar1, bar2, foo2, bar, foo1, bar1, bar2, foo2); 

            #endregion

            #region Task using Thread pool

            //Console.WriteLine("Task using Thread pool");
            //TaskUsingTheadPool();
            //RunSyncTask();
            //LongRunningTask();

            #endregion

            #region Task with return result

            //Console.WriteLine("==Task with return result==");
            //var tt = new Task<Tuple<int, int>>(TaskWithResult, Tuple.Create<int, int>(8, 13));
            //tt.Start();
            //Console.WriteLine(tt.Result);
            //tt.Wait();
            //Console.WriteLine("Result from Task : {0} ,{1}", tt.Result.Item1, tt.Result.Item2);

            #endregion

            #region Continuation Task

            //Console.WriteLine("==Continuation Task==");
            //Task t1 = new Task(DoOnFirst);
            //Task t2 = t1.ContinueWith(DoOnSecond);
            //Task t3 = t1.ContinueWith(DoOnSecond);
            //Task t4 = t2.ContinueWith(DoOnSecond);
            ////   Task t5 = t1.ContinueWith(DoOnError,TaskContinuationOptions.OnlyOnFaulted); 
            #endregion

            #region ParentChild Task

            //Console.WriteLine("==ParentChild Task==");
            //ParentAndChild(); 

            #endregion

            #region Cancellation token
            //Console.WriteLine("==Cancellation token==");
            //var cts = new CancellationTokenSource();
            //cts.Token.Register(() => Console.WriteLine("***token cancelled***"));
            //cts.CancelAfter(500);

            #endregion

            #region Thread Pool

            //Console.WriteLine("==Thread Pool==");
            //int nWorkerThread;
            //int nCompletionPortThread;
            //ThreadPool.GetMaxThreads(out nWorkerThread, out nCompletionPortThread);
            //Console.WriteLine("Max Worker Thread:{0},IO thread {1}", nWorkerThread, nCompletionPortThread);
            //for (int i = 0; i < 5; i++)
            //{
            //    ThreadPool.QueueUserWorkItem(JobForThreads);
            //}
            //Thread.Sleep(2000);
            //var t1 = new Thread(() => Console.WriteLine("running new thread id:{0}", Thread.CurrentThread.ManagedThreadId));
            //t1.Start(); 

            #endregion

            #region Passing Data to Thread

            //Console.WriteLine("==Passing Data to Thread==");
            //var data = new Data { Message = "info" };
            //var t2 = new Thread(ThreadWithParam);
            //t2.Start(data);
            //var t1 = new Thread(ThreadMain) { Name = "MyNewThread", IsBackground = false };
            //t1.Start();

            #endregion

            #region Race Conditions

            //Console.WriteLine("==Race Conditions==");
            //StateObject so = new StateObject();
            //for (int i = 0; i < 2; i++)
            //{
            //    Task.Run(() => new SampleTask().RaceCondition(so));
            //}

            #endregion

            #region DeadLock Conditions

            //Console.WriteLine("==DeadLock Conditions==");
            //StateObject s1 = new StateObject();
            //StateObject s2 = new StateObject();
            //new Task(new SampleTask(s1, s2).DeadLock1).Start();
            //new Task(new SampleTask(s1, s2).DeadLock2).Start();
            //int numTasks = 20;
            //var state = new SharedState();
            //var tasks = new Task[numTasks];
            //for (int i = 0; i < numTasks; i++)
            //{
            //    tasks[i] = Task.Run(() => new Job(state).DoTheJob());
            //}
            //for (int i = 0; i < numTasks; i++)
            //{
            //    tasks[i].Wait();
            //}
            //Console.WriteLine(state.State);

            #endregion

            #region Mutex
            //Console.WriteLine("==Mutex==");
            //bool createNew;
            //Mutex mutt = new Mutex(false, "ProMutext", out createNew);
            //if (mutt.WaitOne())
            //{
            //    try
            //    {
            //        Console.WriteLine("Mutext is waited");
            //    }
            //    finally
            //    {
            //        mutt.ReleaseMutex();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("mutext is waiting");
            //}
            //var mutt1 = new Mutex(false, "ProMutext", out createNew);
            //if (!createNew)
            //{
            //    Console.WriteLine("already created");
            //}
            #endregion

            #region Semaphore

            //Console.WriteLine("==Semaphore==");
            //int taskCount = 6;
            //int semaPhoreCount = 3;
            //var semaphore = new SemaphoreSlim(semaPhoreCount, semaPhoreCount);
            //var task = new Task[taskCount];
            //for (int i = 0; i < taskCount; i++)
            //{
            //    task[i] = Task.Run(() => TaskMain(semaphore));
            //}
            //Task.WaitAll(task);

            #endregion

            #region ManualResetEventSlim

            //Console.WriteLine("==ManualResetEventSlim==");
            //const int taskCount = 4;

            //var mEvent = new ManualResetEventSlim[taskCount];
            //var waitHandle = new WaitHandle[4];
            //var calc = new Calculator[4];

            //for (int i = 0; i < taskCount; i++)
            //{
            //    int i1 = i;
            //    mEvent[i] = new ManualResetEventSlim(false);
            //    waitHandle[i] = mEvent[i].WaitHandle;

            //    calc[i] = new Calculator(mEvent[i]);
            //    Task.Run(() => calc[i1].Calculation(i1 + 1, i1 + 3));
            //}
            //for (int i = 0; i < taskCount; i++)
            //{
            //    int index = WaitHandle.WaitAny(waitHandle);
            //    if (index == WaitHandle.WaitTimeout)
            //    {
            //        Console.WriteLine("Timeout!!");
            //    }
            //    else
            //    {
            //        mEvent[index].Reset();
            //        Console.WriteLine("finished task for {0}, result: {1},task: {2}",
            //        index + 1, calc[index].Result, Task.CurrentId);
            //    }
            //}

            #endregion

            #region Barrier

            Console.WriteLine("==Barrier==");
            const int task = 2;
            const int partitionSize = 1000000;
            var data = new List<string>(FillData(task * partitionSize));
            var barrier = new Barrier(task + 1);
            var t = new Task<int[]>[task];
            for (int i = 0; i < task; i++)
            {
                int jobNumber = i;
                t[i] = Task.Run(() => CalculationInTask(jobNumber, partitionSize, barrier, data));
            }
            barrier.SignalAndWait();
            var resultCollection = t[0].Result.Zip(t[1].Result, (c1, c2) => { return c1 + c2; });
            char ch = 'a';
            int sum = 0;
            foreach (var x in resultCollection)
            {
                Console.WriteLine("{0} count {1}", ch++, x);
                sum += x;
            }
            Console.WriteLine("main finished {0}", sum);
            Console.WriteLine("remaining {0}", barrier.ParticipantsRemaining);
            Console.WriteLine("==ReaderWriterLockSlim==");
            var taskFactory = new TaskFactory(TaskCreationOptions.LongRunning, TaskContinuationOptions.None);
            var task1 = new Task[6];
            ReadProgram rp = new ReadProgram();
            task1[0] = taskFactory.StartNew(ReadProgram.WriteMethod, 1);
            task1[1] = taskFactory.StartNew(ReadProgram.WriteMethod, 1);
            task1[2] = taskFactory.StartNew(ReadProgram.WriteMethod, 2);
            task1[3] = taskFactory.StartNew(ReadProgram.WriteMethod, 2);
            task1[4] = taskFactory.StartNew(ReadProgram.WriteMethod, 3);
            task1[5] = taskFactory.StartNew(ReadProgram.WriteMethod, 3);
            for (int i = 0; i < 6; i++)
            {
                task1[i].Wait();
            }

            #endregion

            Console.ReadLine();
        }

        #region  Parallel Invoke
        static void foo()
        {
            Console.WriteLine("foo " + DateTime.Now.ToString("mm:ss") + " " + Thread.CurrentThread.ManagedThreadId);
        }
        static void bar()
        {
            Console.WriteLine("bar " + DateTime.Now.ToString("mm:ss") + " " + Thread.CurrentThread.ManagedThreadId);
        }
        static void foo1()
        {
            Console.WriteLine("foo1 " + DateTime.Now.ToString("mm:ss") + " " + Thread.CurrentThread.ManagedThreadId);
        }
        static void bar1()
        {
            Console.WriteLine("bar1 " + DateTime.Now.ToString("mm:ss") + " " + Thread.CurrentThread.ManagedThreadId);
        }
        static void foo2()
        {
            Console.WriteLine("foo2 " + DateTime.Now.ToString("mm:ss") + " " + Thread.CurrentThread.ManagedThreadId);
        }
        static void bar2()
        {
            Console.WriteLine("bar2 " + DateTime.Now.ToString("mm:ss") + " " + Thread.CurrentThread.ManagedThreadId);
        }
        #endregion

        #region Task using Thread pool
        static void TaskUsingTheadPool()
        {
            var tf = new TaskFactory();
            Task t1 = tf.StartNew(TaskMethod, "using a task factory");
            Task t2 = Task.Factory.StartNew(TaskMethod, "Using factory via a task");
            var t3 = new Task(TaskMethod, "using task constuction");
            t3.Start();
            Task t4 = Task.Run(() => TaskMethod("using run method"));
        }
        static void RunSyncTask()
        {
            TaskMethod("just main method");
            TaskMethod("another main method");
            new Task(TaskMethod, "run sync").RunSynchronously();
        }
        static void LongRunningTask()
        {
            new Task(TaskMethod, "long running task", TaskCreationOptions.LongRunning).Start();
        }
        static object taskMethodLock = new object();
        static void TaskMethod(object title)
        {
            lock (taskMethodLock)
            {
                Console.WriteLine(title);
                Console.WriteLine("TaskId:{0},thread:{1}", Task.CurrentId == null ? "no task" : Task.CurrentId.ToString(), Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("Is Pool Thread {0}", Thread.CurrentThread.IsThreadPoolThread);
                Console.WriteLine("Is Background Thread {0}", Thread.CurrentThread.IsBackground);
                Console.WriteLine();
            }
        }
        #endregion

        #region Task with return result
        static Tuple<int, int> TaskWithResult(object division)
        {
            Tuple<int, int> div = (Tuple<int, int>)division;
            int result = div.Item1 / div.Item2;
            int remainder = div.Item1 % div.Item2;
            return Tuple.Create<int, int>(result, remainder);
        }
        #endregion

        #region Continuation Task

        static void DoOnFirst()
        {
            Console.WriteLine("do some task {0}", Task.CurrentId);
            //    Thread.Sleep(20);
        }
        static void DoOnSecond(Task t)
        {
            Console.WriteLine("Task {0} is finished", t.Id);
            Console.WriteLine("This task id {0}", Task.CurrentId);
            Console.WriteLine("do some cleanup");
            //    Thread.Sleep(20);
        }
        static void DoOnError()
        {
            Console.WriteLine("Error Occur");
        }

        #endregion

        #region ParentChild Task
        static void ParentTask()
        {
            Console.WriteLine("Task id {0}", Task.CurrentId);
            var child = new Task(ChildTask);
            child.Start();
            Thread.Sleep(100);
            Console.WriteLine("Parent started Child");

        }
        static void ChildTask()
        {
            Console.WriteLine("child");
            Thread.Sleep(200);
            Console.WriteLine("child finished");
        }
        static void ParentAndChild()
        {
            var parent = new Task(ParentTask);
            parent.Start();
            Thread.Sleep(200);
            Console.WriteLine(parent.Status);
            Thread.Sleep(800);
            Console.WriteLine(parent.Status);
        }
        #endregion

        #region  Thread Pool
        static void JobForThreads(Object state)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("loop:{0} for thread {1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(40);
            }
        }
        #endregion

        #region Passing Data to Thread
        public struct Data
        {
            public string Message;
        }
        static void ThreadWithParam(Object o)
        {
            Data d = (Data)o;
            Console.WriteLine("received msg:{0}", d.Message);
        }

        static void ThreadMain()
        {
            Console.WriteLine("Thread {0} started", Thread.CurrentThread.Name);
            Thread.Sleep(3000);
            Console.WriteLine("Thread {0} completed", Thread.CurrentThread.Name);
        }

        #endregion

        #region Race Conditions
        public class StateObject
        {
            private int state = 5;
            private object sync = new object();
            public void ChangeState(int loop)
            {
                lock (sync)
                {
                    if (state == 5)
                    {
                        state++;
                        Trace.Assert(state == 6, "Race condition occur after loop:" + loop);
                    }

                    state = 5;
                }
            }
        }
        public class SampleTask
        {
            private StateObject s1;
            private StateObject s2;
            public SampleTask()
            { }
            public SampleTask(StateObject s1, StateObject s2)
            {
                this.s1 = s1;
                this.s2 = s2;
            }
            public void RaceCondition(object o)
            {
                Trace.Assert(o is StateObject, "o must be state object");
                StateObject so = o as StateObject;
                int i = 0;
                while (true)
                {
                    //lock (so)
                    //{
                    so.ChangeState(i++);
                    // }
                }
            }
            public void DeadLock1()
            {
                int i = 0;
                while (true)
                {
                    lock (s1)
                    {
                        lock (s2)
                        {
                            s1.ChangeState(i);
                            s2.ChangeState(i++);
                            Console.WriteLine("still running, {0}", i);
                        }
                    }
                }
            }
            public void DeadLock2()
            {
                int i = 0;
                while (true)
                {
                    lock (s2)
                    {
                        lock (s1)
                        {
                            s2.ChangeState(i);
                            s1.ChangeState(i++);
                            Console.WriteLine("still running, {0}", i);
                        }
                    }
                }
            }
        }

        #endregion

        #region DeadLock Conditions
        public class SharedState
        {
            public int State { get; set; }
        }

        public class Job
        {
            SharedState ss;
            public Job(SharedState ss)
            {
                this.ss = ss;
            }
            public void DoTheJob()
            {
                for (int i = 0; i < 50000; i++)
                {
                    lock (ss)
                        ss.State += 1;
                }
            }
        }
        #endregion

        #region Semaphore
        static void TaskMain(SemaphoreSlim sslm)
        {
            bool SemaphoreWait = false;
            while (!SemaphoreWait)
            {
                if (sslm.Wait(600))
                {
                    try
                    {
                        Console.WriteLine("task {0} taken lock", Task.CurrentId);
                        Thread.Sleep(2000);
                    }
                    finally
                    {
                        Console.WriteLine("task {0} release", Task.CurrentId);
                        sslm.Release();
                        SemaphoreWait = true;
                    }
                }
                else
                {
                    Console.WriteLine("==Time out for task {0}", Task.CurrentId);

                }

            }
        }
        #endregion

        #region ManualResetEventSlim
        public class Calculator
        {
            private ManualResetEventSlim mEvent;
            public int Result { get; private set; }
            public Calculator(ManualResetEventSlim ev)
            {
                mEvent = ev;
            }
            public void Calculation(int x, int y)
            {
                Console.WriteLine("Task {0} start calculation", Task.CurrentId);
                Thread.Sleep(new Random().Next(3000));
                Result = x + y;
                Console.WriteLine("Task {0} is ready", Task.CurrentId);
                mEvent.Set();

            }
        }
        #endregion

        #region ManualResetEventSlim
        public class ReadProgram
        {
            private static List<int> items = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            private static ReaderWriterLockSlim rwl = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);

            public static void RenderMethod(object reader)
            {
                try
                {
                    rwl.EnterReadLock();
                    for (int i = 0; i < items.Count; i++)
                    {
                        Console.WriteLine("reader {0},loop {1} item {1}", reader, i, items[i]);
                        Thread.Sleep(40);
                    }
                }
                finally
                {
                    rwl.ExitReadLock();
                }
            }
            public static void WriteMethod(object writer)
            {
                try
                {
                    while (!rwl.TryEnterWriteLock(50))
                    {
                        Console.WriteLine("writer {0} waiting for write lock", writer);
                        Console.WriteLine("Current reader lock {0}", rwl.CurrentReadCount);
                    }
                    Console.WriteLine("writer {0} acquire write lock", writer);
                    for (int i = 0; i < items.Count; i++)
                    {
                        items[i]++;
                    }
                    Console.WriteLine("{0} release write lock", writer);
                }
                finally
                {
                    rwl.ExitWriteLock();
                }
            }
        } 
        #endregion

        #region Barrier

        static int[] CalculationInTask(int jobNumber, int participationSize, Barrier br, IList<string> il)
        {
            List<string> data = new List<string>(il);
            int start = jobNumber * participationSize;
            int end = start + participationSize;
            Console.WriteLine("Task {0} partition from {1} to {2}", Task.CurrentId, start, end);
            int[] charCount = new int[26];
            for (int j = start; j < end; j++)
            {
                char c = data[j][0];
                charCount[c - 97]++;
            }
            Console.WriteLine("Calculation complete for task {0} a : {1},z: {2} times", Task.CurrentId, charCount[0], charCount[25]);
            br.RemoveParticipant();
            Console.WriteLine("Task {0} remove,remaining Participant : {1}", Task.CurrentId, br.ParticipantsRemaining);

            return charCount;
        }

        public static IEnumerable<string> FillData(int size)
        {
            var data = new List<string>(size);
            var r = new Random();
            for (int i = 0; i < size; i++)
            {
                data.Add(GetString(r));
            }
            return data;
        }

        private static string GetString(Random r)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                sb.Append((char)(r.Next(26) + 97));
            }
            return sb.ToString();
        }
        #endregion
    }
}
