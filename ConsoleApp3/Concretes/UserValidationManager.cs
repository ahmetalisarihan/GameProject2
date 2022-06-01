using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Concretes
{
    public class UserValidationManager : Abstracts.IUserValidationService
    {
        public bool Validate(Gamer gamer)

        {
           if (gamer.BirthYear == 1993 &&gamer.FirstName == "AHMET ALİ" && gamer.LastName == "SARIHAN" 
                && gamer.IdentityNumber == 57607308534)
            {
                return true;
            }
           else
            {
                return false;
            }
           
                
        }
    }
}
