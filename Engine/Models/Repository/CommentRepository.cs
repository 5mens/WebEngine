using Engine.Data;
using Engine.Models.BaseClasses;
using Engine.Models.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Engine.Models.Repository
{
    public class CommentRepository : IComment
    {
        private readonly IDbContextFactory<AppDbContext> DbFactory;

        public CommentRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            DbFactory = contextFactory;
        }

        public void AddComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetCommentsByAuthor(IdentityUser author)
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
