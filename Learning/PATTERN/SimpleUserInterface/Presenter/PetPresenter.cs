using SimpleUserInterface.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleUserInterface.Presenter
{
    public class PetPresenter
    {
        private IPetView view;
        private string connectionString;

        public PetPresenter(IPetView petView, string connectionString)
        {
            this.view = petView;
            this.connectionString = connectionString;

            // Subscribe to Event at your interface
            this.view.DisplayEvent += DisplayText;
            this.view.Show();
        }

        private void DisplayText(object sender, EventArgs e)
        {
            MessageBox.Show("Text: " + view.PetName + " ==== deep search at : " + connectionString);
        }
    }
}
