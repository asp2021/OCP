using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class AccountService: IAccountService
    {
        public Staff Create(IApplicant person)
        {
            Staff newStaff = new Staff();
            newStaff.FirstName = person.FirstName;
            newStaff.LastName = person.LastName;
            newStaff.Email = $"{person.FirstName}.{person.LastName}@staff.com";

            return newStaff;

        }
    }

}
