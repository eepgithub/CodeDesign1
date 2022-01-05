using CodeDesign1.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesign1
{
    public class Factory
    {
        public static IText CreateText()
        {
            return new RegularText();
        }
    }
}
