using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesign1.Repository
{
    public interface IDataRepository
    {
        public string GetData();
        public string GetCustomer();
        public string GetAnimal();

        public void Save(string data);
        public string Load(string v);

    }
}
