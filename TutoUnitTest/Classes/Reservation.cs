using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TutoUnitTest.Classes
{
    public class Reservation
    {
        public User MadeBy { get;  set; }

        public bool CanBeCAncelledBy(User user)
        {
            return user.IsAdmin || MadeBy == user;
        }
    }

}
