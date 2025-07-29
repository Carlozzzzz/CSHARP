using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlozInventoryV2.Models
{
    public class Log
    {
        public int Id;
        public int UserId;
        public string Username;
        public string Level;
        public string Action;
        public DateTime ModificationTime;
    }
}
