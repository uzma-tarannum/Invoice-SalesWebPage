using WebApplication1.Models.DataAccess;
using WebApplication1.Models.Entitties;
using WebApplication1.ViewModels;

namespace WebApplication1.Factories
{
    public class CustomerFactory : ICustomerFactory
    {
        private readonly ICustomerRepository _customerRepo;
        public CustomerFactory(ICustomerRepository customerRepo)
        {
            _customerRepo = customerRepo;
        }
        public void AddCustomer(CustomerViewModel customer)
        {
            throw new NotImplementedException();
        }

        public void Edit(CustomerViewModel customer)
        {
            var model = new Customer
            {
                Name = customer.Name,
                Id = customer.Id,
                Adress = customer.Adress,
                CategoryCode = customer.CategoryCode,
                AreaCode = customer.AreaCode,
               
            };
            _customerRepo.Edit(model);
        }

        public IList<CustomerViewModel> GetAllCustomers()
        {
            var result = _customerRepo.GetAllCustomers();

            var model = result.Select(customer => new CustomerViewModel
            {
                Name = customer.Name,
                Id = customer.Id,
                Adress = customer.Adress,
                CategoryCode = customer.CategoryCode,
                AreaCode = customer.AreaCode,

            }).ToList();

            return model;
        }

        public IList<CustomerAreaViewModel> GetCustomerArea()
        {
            var result = _customerRepo.GetCustomerArea();
            var model = result.Select(x => new CustomerAreaViewModel
            {
                Name = x.Name,
                Id = x.Id,

            }).ToList();

            return model;
        }

        public CustomerViewModel GetCustomerById(int id)
        {
            var customer = _customerRepo.GetCustomerById(id);

            var model = new CustomerViewModel
            {
                Name = customer.Name,
                Id = customer.Id,
                Adress = customer.Adress,
                CategoryCode = customer.CategoryCode,
                AreaCode = customer.AreaCode,

            };

            return model;
        }

        public IList<CustomerCategoryViewModel> GetCustomerCategory()
        {
            var result = _customerRepo.GetCustomerArea();
            var model = result.Select(x => new CustomerCategoryViewModel
            {
                Name = x.Name,
                Id = x.Id,

            }).ToList();

            return model;
        }
    }
}
