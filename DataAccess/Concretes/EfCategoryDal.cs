using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Repositories;

namespace DataAccess.Concretes;

public class EfCategoryDal : EfRepositoryBase<Category, Guid, TobetoContext>, ICategoryDal
{
    public EfCategoryDal(TobetoContext context) : base(context)
    {

    }
}
