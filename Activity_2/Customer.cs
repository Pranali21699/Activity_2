using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2
{
    public class Customer
    {
        public class Enums
        {
            public enum Gender
            {
                Male, Female,Other
            }
        }
        private string address;
        public static int currentValueForCustomerId;
        private int customerId;
        private string customerName;
        private string customerType;
        private DateTime dateOfBirth;
        private string emailId;
        private Enums.Gender gender;
        private string password;
        public string Address { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailId { get; set; }
        public Enums.Gender Gender { get; set; }
        public string Password { get; set; }

        static Customer()
        {
            currentValueForCustomerId = 1000;
        }
        public Customer()
        {
            customerId = currentValueForCustomerId;
            currentValueForCustomerId++;
            Console.WriteLine(customerId);
        }

        public Customer(string customerName, string address, DateTime dateOfBirth, string emailId, Enums.Gender gender, string password, string customerType)
        {
            customerName = this.customerName;
            address = this.address;
            dateOfBirth = this.dateOfBirth;
            emailId = this.emailId;
            gender = this.gender;
            password = this.password;
            customerType = this.customerType;
        }
        public double GetDiscount()
        {
            double discount = 0.0;
            return discount;
        }
    }
}
