using Project.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.View.IView
{
    public interface ICashierView
    {
        void DisplayProducts(DataTable dataTable);
        void ShowError(string message);
        void ClearProductList(); 
        void UpdateTotal(decimal total);
        void AddRemoveButtonColumn();
        void AddQuantityColumn(); // New method to add editable quantity column
        event Action<string, int> QuantityUpdated; // New event for quantity changes
    }
}
