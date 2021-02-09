using System;

namespace ClassesWithMoshExercises
{
    public class Post
    {
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; private set; }

        public int Vote { get; private set; }

        private static int CurrentId = 0;

        public Post()
        {
            Id = ++CurrentId;
            CreatedDate = DateTime.Now;
        }

        public void UpVote()
        {
            Vote++;
        }

        public void DownVote()
        {
            Vote--;
        }

        public void ShowPost()
        {
            Console.WriteLine("Title: {0}\nDescription: {1}\nCreated Date: {2}\nVote: {3}",
                Title, Description, CreatedDate.ToString("d"), Vote);
        }
    }
}