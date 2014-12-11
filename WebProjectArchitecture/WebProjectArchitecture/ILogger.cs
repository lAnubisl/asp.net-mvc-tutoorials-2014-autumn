using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectArchitecture
{
    public interface ILogger
    {
        void Error(string message);
    }
}
