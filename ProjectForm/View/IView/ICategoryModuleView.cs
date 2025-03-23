using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.View.IView
{
    public interface ICategoryModuleView
    {
        string CategoryName { get; set; }

        event EventHandler? SaveClicked;
        event EventHandler? UpdateClicked;
        event EventHandler? ClearClicked;
        void ShowMessage(string message);
        void ClearMessage();
    }
}
