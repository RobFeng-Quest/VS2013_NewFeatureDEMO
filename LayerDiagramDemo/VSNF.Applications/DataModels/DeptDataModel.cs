using System;
using System.Collections.Generic;
using System.Text;

namespace VSNF.Applications.DataModels
{
    public class DeptDataModel
    {
        public IEnumerable<VSNF.Domain.Department> Departments { get; set; }
    }
}
