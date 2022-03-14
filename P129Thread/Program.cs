using System;
using System.Threading;

namespace P129Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Loop1);
            Thread thread2 = new Thread(Loop2);


            thread1.Start();
            thread2.Start();

            //thread1.Join();
            //thread2.Join();

            //Loop1();
            //Login();

            for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(500);
                Console.WriteLine($"Main1: {i} ThreadId: {Thread.CurrentThread.ManagedThreadId}");
            }

            for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(500);
                Console.WriteLine($"Main2: {i} ThreadId: {Thread.CurrentThread.ManagedThreadId}");
            }


        }

        static void Loop1()
        {
            //Thread.Yield();
            for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(500);
                Console.WriteLine($"Loop1: {i} ThreadId: {Thread.CurrentThread.ManagedThreadId}");
            }
        }

        static void Loop2()
        {
            //Thread.Sleep(1000);
            for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(700);
                Console.WriteLine($"Loop2: {i} ThreadId: {Thread.CurrentThread.ManagedThreadId}");
            }
        }

        //static void Loop1()
        //{
        //    ulong result = 0;
        //    for (ulong i = 0; i < 999999999; i++)
        //    {
        //        result += i;
        //    }
        //    Console.WriteLine(result);
        //}

        //static void Login()
        //{
        //    Console.WriteLine("Login Olundunuz:");
        //}
    }
}
