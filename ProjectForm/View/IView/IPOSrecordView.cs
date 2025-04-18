using Project.Application.DTOs.ProductDtos;
using ProjectForm.Model.DTOs;
using ProjectForm.Model.DTOs.ProductDtos;
using ProjectForm.Model.DTOs.StockRecordDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.View.IView
{
    public interface IPOSrecordView
    {
        //Top Selling
        //event EventHandler? LoadTopSoldItemClicked;
        //event EventHandler<DataGridViewRowPostPaintEventArgs>? RowNumber;
        //event EventHandler? SelectedItemCombo;
        void DisplayTopSellingItems(List<POSrecordDto1> topSelling);
        void DisplaySoldItems(List<POSrecordDto1> sold);
        void DisplayCriticalItems(List<GetAllCriticalProductsDto> criticalItems);
        void DisplayInventoryList(List<GetInventoryListDto> inventoryList);
        void DisplayStockInHistory(List<GetStockInHistoryDto> stockInHistory);
        string SelectedItem(ComboBox comboBox);
        DateOnly StartDate(DateTimePicker dateTimePicker);
        DateOnly EndDate(DateTimePicker dateTimePicker);
        event EventHandler<DataGridViewRowPostPaintEventArgs>? RowNumber;


        //DateOnly StartDate { get; }
        //DateOnly EndDate { get; }
    }
}
