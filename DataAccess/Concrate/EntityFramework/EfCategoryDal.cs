﻿using Core.DataAccess.Concrate.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrate.EntityFramework.Contexts;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfCategoryDal :EfEntityRepositoryBase<Category,NorthwindContext>, ICategoryDal
    {
       
    }
}
