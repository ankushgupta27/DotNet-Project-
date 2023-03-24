using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogMgmt.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;


namespace BlogMgmt.Repository
{
    public class BlogRepository:IBlogRepository
    {
       public List<Blog> GetBlogs() 
       {
           List<Blog> BlogList = new List<Blog>();
        using (var context=new BlogDBContext())
        {
      BlogList = context.Blogs.ToList(); 
        }
        return BlogList;
       }
    }
}