using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    class Program
    {
        static void Main(string[] args)
        {

            // create a post
            var post = new Post("Test Post", "This is the description");

            // upvote post a few times
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();

            // downvote post a few times
            post.DownVote();
            post.DownVote();
            post.DownVote();

            // display current vote value
            post.DisplayVote();
        }
    }
}
