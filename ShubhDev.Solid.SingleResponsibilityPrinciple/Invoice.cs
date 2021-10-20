using ShubhDev.Solid.SingleResponsibilityPrinciple.Email;
using ShubhDev.Solid.SingleResponsibilityPrinciple.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShubhDev.Solid.SingleResponsibilityPrinciple
{
    public class Invoice
    {
        ILogger _logger;
        IEmail _email;

        public Invoice(EmailInfo email, LoggerInfo logger)
        {
            _logger = logger;
            _email = email;
        }

        public async Task<bool> AddVoice()
        {
            var output = await _logger.Info("Add Invoice method started...");
            try
            {
                _email.SendEmail();
            }
            catch (Exception ex)
            {
                await _logger.Error(ex.Message, ex);
            }

            return false;
        }
    }
}
