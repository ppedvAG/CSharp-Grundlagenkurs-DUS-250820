using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M13_Demo_Async_Await
{
    class M13DemoMain
    {
        static void Main(string[] args)
        {
            GebeZahlenAus();

            #region Tasks
            MyTask.DemonstrateTask();
            #endregion

            Console.ReadKey();
        }

        #region await foreach
        static async IAsyncEnumerable<int> GeneriereZahlen()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }
        static async void GebeZahlenAus()
        {
            await foreach (var zahl in GeneriereZahlen())
                Console.WriteLine($"zahl: {zahl}");
        }
        #endregion
    }
}
