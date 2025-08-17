using SimpleUserInterface.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleUserInterface.Presenter
{
    public class MainPresenter
    {
        private IMainView _mainView;
        private string connectionString;

        public MainPresenter(IMainView mainView, string connectionString)
        {
            this._mainView = mainView;
            this.connectionString = connectionString;

            // Subscribe to the events
            this._mainView.ShowPetView += ShowPetsView;
            this._mainView.ShowPersonView += ShowPersonView;
        }

        private void ShowPetsView(object sender, EventArgs e)
        {
            MessageBox.Show("Openning PETS dimention: " + connectionString);
            IPetView view = new PetView();
            new PetPresenter(view, connectionString);
        }

        private void ShowPersonView(object sender, EventArgs e)
        {
            MessageBox.Show("Openning PERSON dimention: " + connectionString);
            IPersonView view = new PersonView();
            new PersonPresenter(view, connectionString);
        }
    }
}
