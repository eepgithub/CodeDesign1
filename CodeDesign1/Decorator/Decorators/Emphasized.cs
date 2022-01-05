using CodeDesign1.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_1.Decorator.Decorators
{
    public class Emphasized : TextDecorator, IEmphasized
    {
        public Emphasized(IText text) : base(text)
        {
            StartTag = "<em>";
            EndTag = "</em>";
        }
    }
}
