using Core.Business.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstracts;

namespace Business.Rules
{
    public class CategoryBusinessRules: BaseBusinessRules
    {
        ICategoryDal _categoryDal;

        public CategoryBusinessRules(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
    }
}
