using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPart2
{
    class Post
    {

        public string title { get; private set; }
        public string description { get; private set; }
        public DateTime createdTime { get; }
        public int votesNumber { get; private set;}

        public Post(string title, string description)
        {
            this.title = title;
            this.description = description;
            createdTime = DateTime.UtcNow;
            votesNumber = 0;
        }

        public void UpVote()
        {
            votesNumber += 1;
        }

        public void DownVote()
        {
            votesNumber -= 1;
        }
    }
}
