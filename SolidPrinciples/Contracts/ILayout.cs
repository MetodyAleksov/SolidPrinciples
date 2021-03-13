using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.Contracts
{
    public interface ILayout
    {
        public DateTime Time { get => DateTime.Now; }


    }
}
