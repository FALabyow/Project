using ProjectForm.Model.DTOs.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.View.IView
{
    public interface ISearchProductView
    {
        event EventHandler? RefreshClicked;
        event EventHandler<DataGridViewRowPostPaintEventArgs>? RowNumber;
        event EventHandler<DataGridViewCellEventArgs>? AddToCartClicked;
        event EventHandler? ProductSearchTextChanged;  
        void DisplayProducts(List<GetAllAvailableProductsDto> _products);
        string SearchText {  get; }
    }
}
