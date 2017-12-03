using System;

namespace Section2ExercisePost
{
    public class Post
    {
        // properties
        private string _title;
        private string _description;
        private DateTime _created;
        private int _voteCount;

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int VoteCount { get; set; }

        public Post()
        {
            Created = DateTime.Now;
        }

        public Post(string title, string description)
            : this()
        {
            this.Title = title;
            this.Description = description;
            this.VoteCount = 0;
        }

        // methods
        public void UpVote()
        {
            VoteCount++;
        }

        public void DownVote()
        {
            VoteCount--;
        }

        public void DisplayVote()
        {
            Console.WriteLine("The post entitled " + Title + " has " + VoteCount + " votes.");
        }
    }
}