using System;
using System.Security.Cryptography;

namespace ClassesWithMoshExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise2();   
        }

        static void Exercise1()
        {
            try
            {
                var stopWatch = new Stopwatch();

                //stopWatch.Start();
                stopWatch.show();
                Console.ReadLine();
                stopWatch.Start();

                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine("Hello World");
                    Console.WriteLine();
                    Console.Clear();
                }

                stopWatch.Stop();

                stopWatch.show();

                Console.ReadLine();

                stopWatch.Start();

                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine("Hello World");
                    Console.WriteLine();
                    Console.Clear();
                }

                stopWatch.Stop();

                stopWatch.show();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Exercise2()
        {
            var post = new Post
            {
                Title = "C# private member issue",
                Description = "Big problem...",
            };

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();

            //post.ShowPost();

            post.DownVote();
            post.DownVote();
            post.DownVote();

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();

            post.ShowPost();
        }
    }
}
