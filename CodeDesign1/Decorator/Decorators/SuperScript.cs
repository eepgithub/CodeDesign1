using CodeDesign1.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_1.Decorator.Decorators
{
    public class SuperScript : TextDecorator, ISuperScript
    {
        public SuperScript(IText text) : base(text)
        {
            StartTag = "<sup>";
            EndTag = "</sup>";
        }
    }
}
