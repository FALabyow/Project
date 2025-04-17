using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.View.IView
{
    public interface ISettlePaymentView
    {
        string Sale {  get; set; }
        string Cash { get; set; }
        string Change {  get; set; }
        event EventHandler? CashTextChanged;
        event EventHandler<KeyPressEventArgs>? CashKeyPressed;
        event EventHandler? EnterClicked;
    }
}
