using System;
using System.Threading;
using System.Threading.Tasks;

namespace logical_exercise.LanguageDotNet
{
    public class AsyncAwait
    {
        public async Task MethodAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    ConsoleUtility.WriteLine($"Counter {i}");
                }
            });
        }

        public void MethodSync()
        {
            for (int i = 0; i < 25; i++)
            {
                ConsoleUtility.WriteLine($"Counter {i}");
            }
        }

        public async Task<int> MethodTask()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    ConsoleUtility.WriteLine($"Counter {i}");
                }
            });
            return count;
        }

        public void ShowThreadInfo(string s)
        {
            ConsoleUtility.WriteLine($"{s} Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        }

        public async void Run()
        {
            AsyncAwait asyncAwait = new AsyncAwait();
            await asyncAwait.MethodAsync();
            await asyncAwait.MethodAsync();
            var t = Task.Run(() => asyncAwait.ShowThreadInfo("Task"));
            t.Wait();
        }


    }
}