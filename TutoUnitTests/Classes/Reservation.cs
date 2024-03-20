using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TutoUnitTests.Classes
{
    public class Reservation
    {
        public User MadeBy { get; private set; }

        public bool CanBeCAncelledBy(User user)
        {
            if(user.IsAdmin)
            {
                return true;
            }
            if(MadeBy == user)
            {
                return true;
            }
            return false;
        }
    }

}
