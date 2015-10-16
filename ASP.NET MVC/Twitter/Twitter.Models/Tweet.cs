namespace Twitter.Models
{
    using System;
    using System.Collections.Generic;

    public class Tweet
    {
        private ICollection<ApplicationUser> favorites;
        private ICollection<Reply> replies; 
        

        public Tweet()
        {
            this.favorites = new HashSet<ApplicationUser>();
            this.replies = new HashSet<Reply>();
        }
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime PostedOn { get; set; }

        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public string WallOwnerId { get; set; }

        public virtual ApplicationUser WallOwner { get; set; }

        public virtual ICollection<ApplicationUser> Favorites {
            get { return this.favorites; }
            set { this.favorites = value; }
        }

        public virtual ICollection<Reply> Replies {
            get { return this.replies; }
            set { this.replies = value; }
        }
    }
}
