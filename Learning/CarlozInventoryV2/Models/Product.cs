using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlozInventoryV2.Models
{
    public class Product
    {
        public int Id = 0;
        public int SupplierId;
        public string SupplierName;
        public string ProductName;
        public string Description;
        public int Quantity;
        public bool IsActive;
        public DateTime ModifiedAt;
        public DateTime CreatedAt;
    }
}
