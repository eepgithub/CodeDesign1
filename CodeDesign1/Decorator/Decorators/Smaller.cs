using CodeDesign1.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_1.Decorator.Decorators
{
    public class Smaller : TextDecorator, ISmaller
    {
        public Smaller(IText text) : base(text)
        {
            StartTag = "<small>";
            EndTag = "</small>";
        }
    }
}
