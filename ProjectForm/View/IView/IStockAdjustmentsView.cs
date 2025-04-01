using ProjectForm.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.View.IView
{
    public interface IStockAdjustmentsView
    {
        public string SelectedItem { get; }
        event EventHandler SelectedItemCombo;
        public void DisplayStocks(List<ProductDto> stocks);
    }
}
