using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.Contracts
{
    public interface IAppender
    {
        public ILayout Layout { get; }
        public void Append(ILogFile file);
    }
}
