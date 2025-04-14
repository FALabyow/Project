using Project.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.View.IView
{
    public interface IDailySaleView
    {
        void DisplayDailySales(List<GetSalesDetailDto> sales);
        void TotalSales(string total);
        DateOnly StartDate { get; }
        DateOnly EndDate { get; }

        event EventHandler? LoadSalesClicked;
        event EventHandler? CloseClicked;
        event EventHandler<DataGridViewRowPostPaintEventArgs>? RowNumber;
        //event EventHandler<KeyEventArgs>? KeyDownPressed;
    }
}
