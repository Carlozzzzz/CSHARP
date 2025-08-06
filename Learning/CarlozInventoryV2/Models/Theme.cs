using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlozInventoryV2.Models
{
    public class Theme
    {
        public int Id;
        public int UserId;
        public Themes SelectionTheme;
    }

    public enum Themes
    { 
        None = -1,
        LightMode = 0,
        DarkMode = 1,
        ClassicMode = 2
    }


}
