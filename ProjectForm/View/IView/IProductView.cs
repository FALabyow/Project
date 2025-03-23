using ProjectForm.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.View.IView
{
    public interface IProductView
    {
        void DisplayProductList(List<ProductDto> productList, int rowNumber);
        void ShowMessage(string message);
        event EventHandler<DataGridViewCellEventArgs> DeleteClicked;
        event EventHandler<DataGridViewCellEventArgs> EditClicked;
    }
}
