using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShubhDev.Solid.SingleResponsibilityPrinciple.Logger
{
    public class LoggerInfo : ILogger
    {
        public async Task<bool> Debug(string info)
        {
            return false;
        }

        public async Task<bool> Error(string message, Exception ex)
        {
            return false;
        }

        public async Task<bool> Info(string info)
        {
            return false;
        }

        public Task<bool> InfoAsync(string info)
        {
            throw new NotImplementedException();
        }
    }
}
