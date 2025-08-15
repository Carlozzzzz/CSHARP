using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_V1.Views
{
    public partial class PetView : Form, IPetView
    {

        // Fields
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tcPet.TabPages.Remove(tpPetDetail);
            btnClose.Click += delegate { this.Close(); };

        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearchPet.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            tbSearchPet.KeyDown += (s, e) =>
                {
                    if (e.KeyCode == Keys.Enter) SearchEvent?.Invoke(this, EventArgs.Empty);
                };

            // Add
            btnAddPet.Click += delegate {
                    AddNewEvent?.Invoke(this, EventArgs.Empty);
                    Console.WriteLine("AddNewEvent is invoked.");
                    tcPet.TabPages.Remove(tpPetList);
                    tcPet.TabPages.Add(tpPetDetail);
                    Console.WriteLine("IsEdit: "+IsEdit);
                };

            // Edit
            btnEditPet.Click += delegate {
                    EditEvent?.Invoke(this, EventArgs.Empty);
                    Console.WriteLine("EditEvent is invoked.");
                    tcPet.TabPages.Remove(tpPetList);
                    tcPet.TabPages.Add(tpPetDetail);
                    Console.WriteLine("IsEdit: " + IsEdit);
                };

            // Save 
            btnSave.Click += delegate {
                    SaveEvent?.Invoke(this, EventArgs.Empty);
                    Console.WriteLine("SaveEvent is invoked.");
                    if (IsSuccessful)
                    {
                        tcPet.TabPages.Remove(tpPetDetail);
                        tcPet.TabPages.Add(tpPetList);

                    }
                    MessageBox.Show(Message);

                };

            // Delete
            btnDeletePet.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected pet?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            // Cancel
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tcPet.TabPages.Add(tpPetList);
                tcPet.TabPages.Remove(tpPetDetail);

            };


        }

        public string PetId { 
            get => tbPetId.Text;
            set => tbPetId.Text = value;
        }
        public string PetName {
            get => tbPetName.Text;
            set => tbPetName.Text = value;
        }
        public string PetType {
            get => tbPetType.Text;
            set => tbPetType.Text = value;
        }
        public string PetColour {
            get => tbPetColour.Text;
            set => tbPetColour.Text = value;
        }
        public string SearchValue {
            get => tbSearchPet.Text;
            set => tbSearchPet.Text = value;
        }
        public bool IsEdit {
            get => isEdit;
            set => isEdit = value;
        }
        public bool IsSuccessful {
            get => isSuccessful;
            set => isSuccessful = value;
        }
        public string Message {
            get => message;
            set => message = value;
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetPetListBindingSource(BindingSource petList)
        {
            petListGridView.DataSource = petList;
        }


        // Singleton pattern (Open a single form instance)
        private static PetView instance;

        public static PetView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PetView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
