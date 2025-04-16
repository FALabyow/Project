using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using ProjectForm.Model.DTOs;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ProjectForm
{
    //part 6 of the tutorial
    //https://www.youtube.com/watch?v=iOc2_NeYF2g&t=490s
    public partial class Cashier : Form, ICashierView
    {
        private readonly CashierPresenter _presenter;
        public Cashier()
        {
            InitializeComponent();
            _presenter = new CashierPresenter(this);
            picClose.Click += (s, e) => CloseClicked?.Invoke(this, EventArgs.Empty);
            timer1.Tick += (s, e) => TimerTicked?.Invoke(this, EventArgs.Empty);
            btnTransaction.Click += Transaction_Click;
            btnSearchProduct.Click += SearchProduct_Click;
            btnPayment.Click += Payment_Click;
            btnLogout.Click += Logout_Click;
            btnDailySales.Click += DailySales_Click;
            btnClearCart.Click += ClearCart_Click;
            adminBtn.Click += Admin_Click;
        }
        
        public event EventHandler? CloseClicked;
        public event EventHandler? TimerTicked;
        public event EventHandler<Button>? TransactionClicked;
        public event EventHandler<Button>? SearchProductClicked;
        public event EventHandler<Button>? PaymentClicked;
        public event EventHandler<Button>? DailySalesClicked;
        public event EventHandler<Button>? LogoutClicked;
        public event EventHandler<Button>? ClearCartClicked;
        public event EventHandler<Button>? AdminClicked;
        public string TransactionNumber
        {
            get => lblTranNo.Text;
            set => lblTranNo.Text = value;
        }
        public string Timer
        {
            get => lblTimer.Text;
            set => lblTimer.Text = value;
        }
        public string DisplayTotal
        {
            get => lblDisplaytotal.Text;
            set => lblDisplaytotal.Text = value;
        }
        public void Slider(Button button)
        {
            pnlSlide.BackColor = Color.SaddleBrown;
            pnlSlide.Height = button.Height;
            pnlSlide.Top = button.Top;
        }
        private void Transaction_Click(object? sender, EventArgs e)
        {
            if(sender is Button button)
            {
                TransactionClicked?.Invoke(this, button);
            }
        }
        private void SearchProduct_Click(object? sender, EventArgs e)
        {
            if(sender is Button button)
            {
                SearchProductClicked?.Invoke(this, button);
            }
        }
        private void Payment_Click(object? sender, EventArgs e)
        {
            if(sender is Button button)
            {
                PaymentClicked?.Invoke(this, button);
            }
        }
        private void ClearCart_Click(object? sender, EventArgs e)
        {
            if(sender is Button button)
            {
                ClearCartClicked?.Invoke(this, button);
            }
        }
        private void DailySales_Click(object? sender, EventArgs e)
        {
            if(sender is Button button)
            {
                DailySalesClicked?.Invoke(this, button);
            }
        }
        private void Admin_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                AdminClicked?.Invoke(this, button);
            }
        }
        private void Logout_Click(object? sender, EventArgs e)
        {
            if( sender is Button button)
            {
                LogoutClicked?.Invoke(this, button);
            }
        }
        private void barcodetxt_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
