using WebApplication1.Models.Entitties;
using WebApplication1.ViewModels;

namespace WebApplication1.Factories
{
    public interface ICustomerFactory
    {
        IList<CustomerViewModel> GetAllCustomers();

        void AddCustomer(CustomerViewModel customer);
        void Edit(CustomerViewModel customer);
        CustomerViewModel GetCustomerById(int id);
        IList<CustomerCategoryViewModel> GetCustomerCategory();
        IList<CustomerAreaViewModel> GetCustomerArea();
    }
}
