using CodeDesign1.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_1.Decorator.Decorators
{
    public class Marked : TextDecorator, IMarked
    {
        public Marked(IText text) : base(text)
        {
            StartTag = "<mark>";
            EndTag = "</mark>";
        }

    }
}
