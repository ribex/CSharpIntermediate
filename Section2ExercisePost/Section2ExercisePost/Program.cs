using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2ExercisePost
{
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
