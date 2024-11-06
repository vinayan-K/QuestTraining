using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CancelllationTockenExample
{
    internal class Program
    {
        static async Task LongRunningActivity(CancellationToken cancellationToken)
        {
            int downloadPercent = 0;
            while (downloadPercent < 101)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine(" Cancelling Download.");
                    break;
                }
                Console.WriteLine("Downloading ......" + downloadPercent++ + "%");
                await Task.Delay(2000);
            }
            }
        public static async Task Main()
        {
            var cancellationtoken = new CancellationTokenSource();
            var task = LongRunningActivity(cancellationtoken.Token);

            Console.WriteLine("press q to exit: ");
            if (Console.ReadKey().KeyChar == 'q')
            {
                cancellationtoken.Cancel();
            }
            await task;

        }
    }
}
