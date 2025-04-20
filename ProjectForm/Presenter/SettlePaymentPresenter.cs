using ProjectForm.View.IView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.Presenter
{
    public class SettlePaymentPresenter
    {
        private readonly ISettlePaymentView _settlePaymentView;
        private readonly ICashierView _cashierView;
        public SettlePaymentPresenter(ISettlePaymentView settlePaymentView, ICashierView cashierView)
        {
            _cashierView = cashierView;
            _settlePaymentView = settlePaymentView;
            _settlePaymentView.Sale = _cashierView.DisplayTotal;
            _settlePaymentView.CashKeyPressed += OnCashKeyPressed;
            _settlePaymentView.CashTextChanged += OnCashTextChanged;
            _settlePaymentView.EnterClicked += OnEnterClicked;
        }
        private void OnCashKeyPressed(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.' || _settlePaymentView.Cash.Contains(".")))
            {
                e.Handled = true; // Block invalid characters
            }
        }
        private void OnCashTextChanged(object? sender, EventArgs e)
        {            
            decimal sale = decimal.Parse(_settlePaymentView.Sale);

            if(decimal.TryParse(_settlePaymentView.Cash, out decimal cash))
            {
               
            }
            else
            {
                cash = 0;
            }

            if (decimal.TryParse(_settlePaymentView.Change, out decimal change))
            {
               
            }
            else
            {
                change = 0;
            }

            change = cash - sale;
            _settlePaymentView.Change = $"{change}";
            
        }
        private void OnEnterClicked(object? sender, EventArgs e)
        {
            if(_settlePaymentView.Change.Contains("-"))
            {
                MessageBox.Show("Invalid changed value");
                return;
            }
            _cashierView.Total = _settlePaymentView.Sale;
            _cashierView.Cash = _settlePaymentView.Cash;
            _cashierView.Change = _settlePaymentView.Change;
        }
    }
}
