﻿using ShopOnline.Data.Infrastructure;
using ShopOnline.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopOnline.Data.Reponsitories
{
    //định nghĩa thêm các phương thức k có sẵn
    public interface IProductCategoryRepository: IRepository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}