using CodeDesign1.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_1.Decorator.Decorators
{
    public class Important : TextDecorator, IImportant
    {
        public Important(IText text) : base(text)
        {
            StartTag = "<strong>";
            EndTag = "</strong>";
        }
    }
}
