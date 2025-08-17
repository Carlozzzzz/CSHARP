using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleUserInterface.View
{
    public partial class PetView2 : Form, IPetView
    {
        public PetView2()
        {
            InitializeComponent();
            btnDisplay.Click += delegate { DisplayEvent?.Invoke(this, EventArgs.Empty); };
        }

        public string PetName { 
            get => tbName.Text; 
            set => tbName.Text = value; }

        public event EventHandler DisplayEvent;
    }
}
