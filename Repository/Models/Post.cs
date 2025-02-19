﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Post
    {
        public Post()
        {
            TagPosts = new HashSet<TagPost>();
            Wishes = new HashSet<Wish>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string CategoryId { get; set; }
        public string UserId { get; set; }
        public decimal? Price { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public int? Status { get; set; }

        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<TagPost> TagPosts { get; set; }
        public virtual ICollection<Wish> Wishes { get; set; }
    }
}
