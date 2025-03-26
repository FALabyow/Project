using ProjectForm.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.View.IView
{
    public interface IStockEntryView
    {
        //void DisplayProductList(List<StockInProductDto> productList);
        string ReferenceNum { get; set; }
        void DisplayReferenceNumber(string referenceNumber);
        void DisplayStockEntry(StockInProductDto stockInList);
        event Action? OnDateSelected;
        DateTimePicker DatePicker { get; }
        event EventHandler<DataGridViewCellEventArgs>? DeleteClicked;


    }
}
