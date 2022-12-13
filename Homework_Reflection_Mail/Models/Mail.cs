using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Reflection_Mail.Models
{
    public class Mail
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public string MailCreator(string firstname, string lastname) {
            
            this.Username = (firstname + "." + lastname).ToLower();
            this.Email = this.Username + " @mail.com";

            return this.Email;
        }

    }
}
