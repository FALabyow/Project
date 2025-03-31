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
        List<StockRecordDto> GetStockRecordsFromGrid();
        void DisplayStockEntry(ProductDto stocksList);
        void DisplayStockRecords(List<StockRecordDto> filteredRecords);

        event Action? OnDateSelected;
        DateTimePicker DatePicker { get; }
        DateOnly StartDate { get; }
        DateOnly EndDate { get; }
        event EventHandler<DataGridViewCellEventArgs>? DeleteClicked;
        event EventHandler? LoadFilteredRecordsClicked;


    }
}
