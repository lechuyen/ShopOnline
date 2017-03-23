using ShopOnline.Data.Infrastructure;
using ShopOnline.Model.Models;

namespace ShopOnline.Data.Reponsitories
{
    public interface ITagReponsitory : IRepository<Tag>
    {
    }

    public class TagRepository : RepositoryBase<Tag>, ITagReponsitory
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}