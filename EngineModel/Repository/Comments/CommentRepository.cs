using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngineModels.Interfaces.Comments;
using EngineModels.Models.Articles;
using EngineModels.Models.Comments;
using EngineModels.Models.Users;

namespace EngineModels.Repository.Comments
{
    public class CommentRepository : IComment
    {
        private readonly ApplicationDbContext applicationDbContext;
        public CommentRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public void AddComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetCommentsByAuthor(User author)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetCommentsByContent(Article article)
        {
            throw new NotImplementedException();
        }

        public void UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
