using WebApplication1.Models.Entitties;

namespace WebApplication1.Models.DataAccess
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly EBMContext _db;
        public CustomerRepository(EBMContext db)
        {
            _db = db;
        }
        public void AddCustomer(Customer customer)
        {
            _db.Customer.Add(customer);
            _db.SaveChanges();
        }

        public void Edit(Customer customer)
        {
            _db.Customer.Update(customer);

            _db.SaveChanges();
        }

        public IList<Customer> GetAllCustomers()
        {
            return _db.Customer.ToList();
        }

        public IList<CustomerArea> GetCustomerArea()
        {
            return _db.CustomerArea.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            var result = _db.Customer.Find(id);
            return result;
        }

        public IList<CustomerCategory> GetCustomerCategory()
        {
            return _db.CustomerCategory.ToList();
        }
    }
}
