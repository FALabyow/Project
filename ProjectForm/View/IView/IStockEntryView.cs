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
        List<StockRecordInfoDto> GetStockRecordsFromGrid();
        void DisplayStockEntry(StockInDto stocksList);
        void DisplayStockRecords(List<StockRecordInfoDto> filteredRecords);

        event Action? OnDateSelected;
        DateTimePicker DatePicker { get; }
        DateOnly StartDate { get; }
        DateOnly EndDate { get; }
        event EventHandler<DataGridViewCellEventArgs>? DeleteClicked;
        event EventHandler? LoadFilteredRecordsClicked;


    }
}
