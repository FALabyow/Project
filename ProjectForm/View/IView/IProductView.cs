using Project.Application.DTOs.ProductDtos;
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
        void DisplayProductList(List<GetAllProductDto> productList);
        string SearchText { get; }
        void ShowMessage(string message);
        event EventHandler<DataGridViewCellEventArgs>? DeleteClicked;
        event EventHandler<DataGridViewCellEventArgs>? EditClicked;
        event EventHandler<DataGridViewRowPostPaintEventArgs>? RowNumber;
        event EventHandler? ProductSearched;
        event EventHandler? AddClicked;
    }
}
