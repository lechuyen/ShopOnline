using ShopOnline.Data.Infrastructure;
using ShopOnline.Model.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ShopOnline.Data.Reponsitories
{
    //định nghĩa thêm các phương thức k có sẵn
    public interface IPostCategoryRepository : IRepository<PostCategory>
    {
      
    }

    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

       
    }
}