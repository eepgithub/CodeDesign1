using CodeDesign1.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_1.Decorator.Decorators
{
    public class Inserted : TextDecorator, IInserted
    {
        public Inserted(IText text) : base(text)
        {
            StartTag = "<ins>";
            EndTag = "</ins>";
        }
    }
}
