using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarlozInventoryV2.Models
{
    public class Supplier
    {
        public int Id = 0;
        public string SupplierName;
        public string Email;
        public string Phone;
        public bool IsActive;
        public DateTime ModifiedAt;
        public DateTime CreatedAt;
    }
}
