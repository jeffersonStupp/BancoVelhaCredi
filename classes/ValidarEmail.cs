using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoVelhaCredi.classes
{
    public static class ValidarEmail
    {
        public static bool validaremail(string email)
        {
            try
            {
                var endmail = new System.Net.Mail.MailAddress(email);
                return endmail.Address == email;
            }
            catch 
            {

                return false;
            }
        }
    }
}
