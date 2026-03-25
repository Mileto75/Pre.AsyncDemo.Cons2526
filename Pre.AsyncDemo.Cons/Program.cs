using Pre.AsyncDemo.Cons.Services;

namespace Pre.AsyncDemo.Cons
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Async await demo!");
            //perform sync, async, and await to demonstrate differences
            FileService fileService = new();
            Console.WriteLine("Create a large file!");
            await fileService.CreateLargeFile();
            Console.WriteLine("file created");
            //while(!task.IsCompleted)
            //{
            //    //do something.
            //    Console.Write("+");
            //    //simulate a delay to show the pluskes
            //    await Task.Delay(100);
            //}
        }
    }
}
