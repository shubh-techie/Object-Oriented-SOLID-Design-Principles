using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShubhDev.Solid.SingleResponsibilityPrinciple.Email
{
    public class EmailInfo : IEmail
    {
        public string EMailTo { get; set; }
        public string EMailSubject { get; set; }
        public string EMailBody { get; set; }

        public void SendEmail()
        {
            throw new NotImplementedException();
        }
    }
}
