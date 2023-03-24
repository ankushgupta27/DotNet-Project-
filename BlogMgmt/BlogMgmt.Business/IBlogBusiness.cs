using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogMgmt.Data.Entities;

namespace BlogMgmt.Business
{
    public interface IBlogBusiness
    {
         List<Blog> GetBlogs();
    }
}