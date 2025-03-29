using ProjectForm.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.View.IView
{
    public interface IStockInProductView
    {
        event EventHandler<DataGridViewCellEventArgs>? SelectProductClicked;
        void DisplayProductList(List<ProductDto> productsList);
        void ShowMessage(string message);
    }
}
