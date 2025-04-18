using ProjectForm.Model.DTOs.CategoryDto;
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
        int ReOrder { get; set; }
        decimal Price { get; set; } 
        Guid SelectedCategory { get; }
        void LoadCategory(List<CategoryDto> categoryDto);
        void Clear();
        void ShowMessage(string message);
        void ModuleClose();
        void LoadingMessage(string message);
        event EventHandler? ClearClicked;
        event EventHandler? SelectedIndexCategoryCombo;
        event EventHandler? SaveClicked;
        event EventHandler? ModuleCloseClicked;       
    }
}
