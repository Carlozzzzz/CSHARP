using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUserInterface.View
{
    public interface IPetView
    {
        // Properties
        string PetName { get; set; }

        // Events
        event EventHandler DisplayEvent;

        // Optional, but this allows you to call the Show method on Presenter using the view object
        void Show();
    }
}
