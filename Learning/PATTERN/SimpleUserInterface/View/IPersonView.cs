using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUserInterface.View
{
    public interface IPersonView
    {
        string PersonName { get; set; }
        string ValidatedText { get; set; }
        Color DeepSearchColor { get; set; }

        event EventHandler DisplayEvent;
        event EventHandler DeepSearchEvent;

        void Show();
    }
}
