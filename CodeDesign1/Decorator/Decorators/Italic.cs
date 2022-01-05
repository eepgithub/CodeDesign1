using CodeDesign1.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_1.Decorator.Decorators
{
    public class Italic : TextDecorator, IItalic
    {
        public Italic(IText text) : base(text)
        {
            StartTag = "<i>";
            EndTag = "</i>";
        }
    }
}
