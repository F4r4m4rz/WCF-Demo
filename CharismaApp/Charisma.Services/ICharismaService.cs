using Charisma.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Charisma.Services
{
    [ServiceContract]
    public interface ICharismaService
    {
        [OperationContract]
        List<MenuItem> GetMenuItems();

        [OperationContract]
        List<Customer> GetCustomers();

        [OperationContract]
        void PlaceOrder(Order order);
    }
}
