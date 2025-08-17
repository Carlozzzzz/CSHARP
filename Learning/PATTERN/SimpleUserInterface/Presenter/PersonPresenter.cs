using SimpleUserInterface.View;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleUserInterface.Presenter
{
    public class PersonPresenter
    {
        private IPersonView view;
        private string connectionString;

        public PersonPresenter(IPersonView personView, string connectionString)
        {
            this.view = personView;
            this.connectionString = connectionString;

            this.view.DisplayEvent += ShowText;
            this.view.DeepSearchEvent += DeepSearchPerson;
            this.view.Show();
        }

        private void ShowText(object sender, EventArgs e)
        {
            MessageBox.Show("Your Name: " + view.PersonName);
        }

        private void DeepSearchPerson(object sender, EventArgs e)
        {
            string message = connectionString + " deep search: ";
            if (view.PersonName.Trim() == "carlos")
            {
                message += "you are so handsome.";
                view.DeepSearchColor = Color.Green;
            }
            else if (view.PersonName.Trim() == "dianna")
            {
                message += "you are much much more brighter than the moon.";
                view.DeepSearchColor = Color.Green;
            }
            else
            {
                message += "you are average person.";
                view.DeepSearchColor = Color.Gray;
            }
            view.ValidatedText = message;
        }
    }
}
