using ProjectForm.Model.DTOs;
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
        void DisplayCriticalItems(List<POSrecordDto2> criticalItems);
        void DisplayInventoryList(List<GetInventoryListDto> inventoryList);
        string SelectedItem(ComboBox comboBox);
        DateOnly StartDate(DateTimePicker dateTimePicker);
        DateOnly EndDate(DateTimePicker dateTimePicker);

        //DateOnly StartDate { get; }
        //DateOnly EndDate { get; }
    }
}
