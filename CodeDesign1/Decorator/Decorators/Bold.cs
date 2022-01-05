using CodeDesign1.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_1.Decorator.Decorators
{
    public class Bold : TextDecorator, IBold
    {

        public Bold(IText text) : base(text)
        {
            StartTag = "<b>";
            EndTag = "</b>";
        }
    }
}
