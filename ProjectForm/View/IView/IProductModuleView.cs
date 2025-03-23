using ProjectForm.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.View.IView
{
    public interface IProductModuleView
    {
        string Pcode { get; set; }
        string Barcode { get; set; }
        string Description { get; set; }
        int Preorder { get; set; }
        decimal Price { get; set; }
        int Quantity { get; set; }  
        Guid Selectedcategory { get; }
        void LoadCategory(List<CategoryDto> categoryDto);
        void Clear();
        void ShowMessage(string message);   
        void LoadingMessage(string message);
        event EventHandler? ClearClicked;
        event EventHandler? SelectedIndexCategoryCombo;
        event EventHandler? SaveClicked;
        event EventHandler? UpdateClicked;
    }
}
