using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.S_and_I__SOLID
{
    public class Test
    {
        static void Main()
        {
            string mail = null;
            string error = null;
            SendMail send = new SendMail();
            Log log = new Log();
            User u = new User();
            bool login = u.Login("Pritam", "1234"); // This time Successful Mail will be sent.
            //bool login = u.Login(null, null); // This time Error will log.
            if (!login)
            {
                error = "error logged";
                
            }
            else
            {
                mail = "Send e-mail";
                
            }

            if (send.SendEMail(mail))
            {
                Console.WriteLine("Login Successfull!!!!...Email sent to recipient.");
            }
            if (log.ErrorLog(error))
            {
                Console.WriteLine("Error Occured...");
            }



            Console.Read();
        }
    }
}
