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
    public partial class PersonView : Form, IPersonView
    {
        private string validatedText;
        public PersonView()
        {
            InitializeComponent();

            btnDisplay.Click += delegate { DisplayEvent?.Invoke(this, EventArgs.Empty); };
            btnDeepSearch.Click += delegate { DeepSearchEvent?.Invoke(this, EventArgs.Empty); };
        }

        public string PersonName { 
            get => tbName.Text; 
            set => tbName.Text = value; 
        }
        public string ValidatedText { 
            get => validatedText; 
            set => lblDeepSearch.Text = value; 
        }
       
        public Color DeepSearchColor { 
            get => lblDeepSearch.ForeColor; 
            set => lblDeepSearch.ForeColor = value; 
        }

        public event EventHandler DisplayEvent;
        public event EventHandler DeepSearchEvent;
    }
}
