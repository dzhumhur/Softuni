namespace Twitter.Models
{
    using System;

    public class Reply
    {
        public int Id { get; set; }

        public string Conent { get; set; }

        public DateTime PostedOn { get; set; }

        public int TweetId { get; set; }

        public virtual Tweet Tweets { get; set; }

        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }
    }
}
