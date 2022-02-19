using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAndAbstractDemo.Entity;

namespace InterfaceAndAbstractDemo.Abstract
{
    public interface ICustomerService:IEntity
    {
        void Save(Customer customer);
    }
}
