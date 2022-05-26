using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDKSDatabase.Models.ViewModels
{
    public class TransactionIndexData
    {
        public IEnumerable<Transaction> Transactions { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Vehicle> Vehicles { get; set; }
    }
}
