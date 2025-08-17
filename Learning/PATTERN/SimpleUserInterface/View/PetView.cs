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
    public partial class PetView : Form, IPetView
    {
        public PetView()
        {
            MessageBox.Show("Inside Petview");
            InitializeComponent();
            btnDisplay.Click += delegate { DisplayEvent?.Invoke(this, EventArgs.Empty);  };
        }

        public string PetName { 
            get => tbName.Text.Trim().ToLower(); 
            set => tbName.Text = value; }

        public event EventHandler DisplayEvent;
    }
}
