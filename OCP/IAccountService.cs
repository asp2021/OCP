using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public interface IAccountService
    {
        Staff Create(IApplicant person);
    }
}
