using CodeDesign1.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_1.Decorator.Decorators
{
    public class SubScript : TextDecorator, ISubScript
    {
        public SubScript(IText text) : base(text)
        {
            StartTag = "<sub>";
            EndTag = "</sub>";
        }
    }
}
