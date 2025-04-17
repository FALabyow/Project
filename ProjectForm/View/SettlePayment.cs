using ProjectForm.Presenter;
using ProjectForm.View.IView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForm
{
    public partial class SettlePayment : Form, ISettlePaymentView
    {
        private SettlePaymentPresenter _presenter;
        private readonly ICashierView _cashierView;
        public SettlePayment(ICashierView cashierView)
        {
            InitializeComponent();
            _cashierView = cashierView;
            _presenter = new SettlePaymentPresenter(this, _cashierView);
            txtCash.KeyPress += Cash_KeyPress;
            txtCash.TextChanged += (s, e) => CashTextChanged?.Invoke(this, EventArgs.Empty);
            btnEnter.Click += (s, e) => EnterClicked?.Invoke(this, EventArgs.Empty);    
        }
        
        public event EventHandler? CashTextChanged;
        public event EventHandler<KeyPressEventArgs>? CashKeyPressed;
        public event EventHandler? EnterClicked;

        public string Sale
        {
            get => txtSale.Text;
            set => txtSale.Text = value;
        }
        public string Cash
        {
            get => txtCash.Text;
            set => txtCash.Text = value;
        }
        public string Change
        {
            get => txtChange.Text;  
            set => txtChange.Text = value;
        }
        private void Cash_KeyPress(object? sender, KeyPressEventArgs e)
        {           
            CashKeyPressed?.Invoke(sender, e);            
        }
        
    }

}