using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebookProjectPractice
{
    internal class Person
    {
        private string id;
        private string firstName;
        private string lastName;
        private string phone;
        private string email;
        private string address;
        private string notes;

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
    }
}
