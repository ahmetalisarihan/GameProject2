using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Abstracts
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
