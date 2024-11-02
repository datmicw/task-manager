using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_manager.Entities;
using task_manager.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace task_manager.BLL
{
    public class CustomerBLL
    {
        private readonly CustomerDAL customerDAL;

        public CustomerBLL()
        {
            customerDAL = new CustomerDAL();
        }
        public  void AddCustomer(CustomerEnti customer)
        {
            ValidateCustomer(customer);
            customerDAL.AddCustomer(customer);
        }
        public CustomerEnti GetCustomer(string email)
        {
            return customerDAL.GetCustomerByEmail(email);
        }
        private void ValidateCustomer(CustomerEnti customer)
        {
            if (string.IsNullOrWhiteSpace(customer.Name))
                throw new ArgumentException("Name không được để trống.");
            if (string.IsNullOrWhiteSpace(customer.Email))
                throw new ArgumentException("Email không được để trống.");
            if (string.IsNullOrWhiteSpace(customer.Password))
                throw new ArgumentException("Password không được để trống.");

        }

    }
}
