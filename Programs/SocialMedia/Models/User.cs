﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SocialMedia.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UserPhone { get; set; } = string.Empty;
        public int Age { get; set; }
        //public ICollection<Post> Posts { get; set; }
        //public ICollection<Group> Groups { get; set; }
    }
}
