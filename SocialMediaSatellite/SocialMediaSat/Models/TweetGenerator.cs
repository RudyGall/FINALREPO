//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocialMediaSat.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    public partial class TweetGenerator
    {
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Likes { get; set; }
        public int Retweets { get; set; }
        public string Text { get; set; }
    }
}
