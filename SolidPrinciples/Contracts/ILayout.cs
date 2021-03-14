using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace SolidPrinciples.Contracts
{
    public interface ILayout
    { 
        public string GetMessage(ILogFile file);
    }
}
