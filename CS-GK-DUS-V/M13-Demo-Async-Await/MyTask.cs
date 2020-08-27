using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M13_Demo_Async_Await
{
    static class MyTask
    {
        public static void DemonstrateTask()
        {
            Action<object> action = (object obj) =>
            {
                Console.WriteLine("Task={0}, obj={1}, Thread={2}", Task.CurrentId, obj, Thread.CurrentThread.ManagedThreadId);
            };

            // einen Task vorbereiten
            Task t1 = new Task(action, "task1");

            // einen Task anlegen und starten
            Task t2 = Task.Factory.StartNew(action, "task2");
            Console.WriteLine("t2 wurde gestartet. Hauptthread={0}", Thread.CurrentThread.ManagedThreadId);
            t2.Wait(); // warten, bis Task fertig ist

            t1.Start();
            // t1.Wait(); solange man auf das Beenden vom Task nicht warten lässt, wird der Code danach ausgeführt.
            Console.WriteLine("t1 wurde gestartet. Hauptthread={0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("t1 wurde gestartet. Hauptthread={0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("t1 wurde gestartet. Hauptthread={0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("t1 wurde gestartet. Hauptthread={0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("t1 wurde gestartet. Hauptthread={0}", Thread.CurrentThread.ManagedThreadId);
            // mit Start() wurde erst die Zeile oben ausgeführt, und danach die action von t1.

            string taskData = "task3";
            Task t3 = Task.Run(
                () =>
                {
                    Console.WriteLine("Task={0}, taskData={1}, Thread={2}", Task.CurrentId, taskData, Thread.CurrentThread.ManagedThreadId);
                });
            t3.Wait();

            Task t4 = new Task(action, "task4");
            // erst action ausführen, dann die nächste Zeile
            // bei synchronem Ablaufen wird kein Unterthread angelegt. Thread = Hauptthread. 
            t4.RunSynchronously();
            Console.WriteLine("t4 wurde gestartet. Hauptthread={0}", Thread.CurrentThread.ManagedThreadId);
            t4.Wait();


        }

    }
}
