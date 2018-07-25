using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDetails
{
    class QualificationIsEmpty : Exception
    {
        public QualificationIsEmpty(String message) : base(message)
        {

        }
    }
}
