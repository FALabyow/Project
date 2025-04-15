using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.View.IView
{
    public interface ICashierView
    {
        event EventHandler? CloseClicked; //to close the application
        string TransactionNumber { get; set; } //this is for the SaleHistoryId
        string DisplayTotal { get; set; }   
        event EventHandler? TimerTicked;
        event EventHandler<Button>? TransactionClicked;
        event EventHandler<Button>? SearchProductClicked;
        event EventHandler<Button>? PaymentClicked;
        event EventHandler<Button>? DailySalesClicked;
        event EventHandler<Button>? LogoutClicked;
        event EventHandler<Button>? ClearCartClicked;
        string Timer { get; set; }
        void Slider(Button button);
    }
}
