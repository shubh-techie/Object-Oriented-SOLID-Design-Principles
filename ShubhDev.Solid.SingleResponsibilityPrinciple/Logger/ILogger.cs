using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShubhDev.Solid.SingleResponsibilityPrinciple.Logger
{
    public interface ILogger
    {
        Task<bool> InfoAsync(string info);
        Task<bool> Debug(string info);
        Task<bool> Error(string message, Exception ex);
    }
}
