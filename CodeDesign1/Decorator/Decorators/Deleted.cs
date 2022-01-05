using CodeDesign1.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_1.Decorator.Decorators
{
    public class Deleted : TextDecorator, IDeleted
    {
        public Deleted(IText text) : base(text)
        {
            StartTag = "<del>";
            EndTag = "</del>";
        }
    }
}
