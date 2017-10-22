using System;
using System.Collections.Generic;
using System.Text;

namespace Miles.People.List
{
    class Company
    {
        public Company()
        {

        }

        public IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee> {
                new Employee { FirstName="Peter", LastName="Samuel", Title="Senior Consultant", Description="Peter needs more time to create workshop material."},
                new Employee { FirstName="Tom", LastName="Thorsen", Title="Senior Consultant", Description=""},
                new Employee { FirstName="Kenneth", LastName="P", Title="Senior Consultant", Description=""},
                new Employee { FirstName="Olav", LastName="Lund Nilsen", Title="Daily slave", Description=""},
                new Employee { FirstName="Bjørn", LastName="Nordgulen", Title="Senior Consultant", Description=""},
            };
        }
    }
}
