﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnIt.Model.Repository
{
   public class RepositoryData<T> where T : class
   {
      protected DbContext DbContext { get; set; }
      protected DbSet<T> DbSet { get; set; }

      public RepositoryData(OnItDbContext dbConext)
      {
         DbContext = dbConext;
         DbSet = DbContext.Set<T>();
      }

      public IQueryable<T> GetData(/*string orderBy, string filter, params object[] paremetersFilter*/)
      {
         return DbSet;
      }
   }
}
