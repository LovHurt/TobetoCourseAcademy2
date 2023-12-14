using Core.Business.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Messages;
using DataAccess.Abstracts;
using Core.CrossCuttingConcerns.Exceptions.Types;

namespace Business.Rules
{
    public class CourseBusinessRules: BaseBusinessRules
    {
        ICourseDal _courseDal;

        public CourseBusinessRules(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

    }
}
