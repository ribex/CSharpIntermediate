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
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        private int VoteCount { get; set; }

        // methods
        public void UpVote()
        {
            
        }

        public void DownVote()
        {
            
        }

        public void DisplayVote()
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // create a post
            var post = new Post();

            // upvote post a few times
            post.UpVote();

            // downvote post a few times
            post.DownVote();

            // display current vote value
            post.DisplayVote();
        }
    }
}
