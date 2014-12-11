using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProjectArchitecture.Models
{
    public class PostItemViewModel
    {
        private readonly string title;
        private readonly string summary;
        private readonly DateTime dateCreated;
        private readonly int commentsCount;

        public PostItemViewModel(string title, string summary, DateTime dateCreated, int commentsCount)
        {
            this.title = title;
            this.summary = summary;
            this.dateCreated = dateCreated;
            this.commentsCount = commentsCount;
        }

        public string Title
        {
            get { return title; }
        }

        public string Summary
        {
            get { return summary; }
        }

        public DateTime DateCreated
        {
            get { return dateCreated; }
        }

        public int CommentsCount
        {
            get { return commentsCount; }
        }
    }
}