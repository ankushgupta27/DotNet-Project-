using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogMgmt.Repository;
using BlogMgmt.Data.Entities;


namespace BlogMgmt.Business
{
    public class BlogBusiness:IBlogBusiness
    {
        public readonly IBlogRepository _iBlogRepository;
        public BlogBusiness(IBlogRepository iBlogRepository)
        {
            _iBlogRepository=iBlogRepository;
        }
        public List<Blog> GetBlogs()
        {
return _iBlogRepository.GetBlogs();
        }
    }
}

