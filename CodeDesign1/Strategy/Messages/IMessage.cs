using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesign1.Strategy.Messages
{
    public interface IMessage
    {
        public void SendMessage(string message);
    }
}
