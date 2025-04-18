using Project.Application.DTOs.StockrRecordDtos;
using ProjectForm.Model.DTOs;
using ProjectForm.Model.DTOs.StockDtos;
using ProjectForm.Model.DTOs.StockRecordDtos;
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
        List<GetAllStocksRecordDto> GetStockRecordsFromGrid();
        void DisplayStockEntry(AddStockEntryDto stocksList);
        void DisplayStockRecords(List<GetAllStocksRecordDto> filteredRecords);

        event Action? OnDateSelected;
        DateTimePicker DatePicker { get; }
        DateOnly StartDate { get; }
        DateOnly EndDate { get; }
        event EventHandler<DataGridViewCellEventArgs>? DeleteClicked;
        event EventHandler<LinkLabelLinkClickedEventArgs>? LinkReferenceClicked;
        event EventHandler<LinkLabelLinkClickedEventArgs>? LinkProductClicked;
        event EventHandler? LoadFilteredRecordsClicked;
        //event EventHandler? StockEntryFormLoad;


    }
}
