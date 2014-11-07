using Forms.Repository;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Forms.Models
{
    public class ArticleModel
    {
        public ArticleModel()
        {
  
        }

        public ICollection<string> Comments 
        {
            get
            {
                return CommentsRepository.Comments;
            }
        }

        //public ICollection<CommentItemModel> Comments { get; set; }
    }
}