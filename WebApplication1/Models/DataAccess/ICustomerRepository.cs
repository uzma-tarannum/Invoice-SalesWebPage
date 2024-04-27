using WebApplication1.Models.Entitties;

namespace WebApplication1.Models.DataAccess
{
    public interface ICustomerRepository
    {
        IList<Customer> GetAllCustomers();

        void AddCustomer(Customer customer);
        void Edit(Customer customer);
        Customer GetCustomerById(int id);
        IList<CustomerCategory> GetCustomerCategory();
        IList<CustomerArea> GetCustomerArea();
    }
}
