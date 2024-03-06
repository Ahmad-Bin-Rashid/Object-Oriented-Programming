using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.BL
{
    internal class Comment
    {
        private string comment;
        private string CommentedBy;

        public Comment(string CommentContent, string CommentBy)
        {
            this.comment = CommentContent;
            this.CommentedBy = CommentBy;
        }

        public Comment() { }

        public void SetComment(string CommentContent)
        {
            this.comment = CommentContent;
        }

        public string GetCommentContent()
        {
            return this.comment;
        }

        public void SetCommentBy(string CommentBy)
        {
            this.CommentedBy = CommentBy;
        }

        public string GetCommentBy()
        {
            return this.CommentedBy;
        }
    }
}
