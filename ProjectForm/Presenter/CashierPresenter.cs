using ProjectForm.View.IView;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForm.Presenter
{
    public class CashierPresenter
    {
        private readonly ICashierView _view;
        public CashierPresenter(ICashierView view)
        {
            _view = view;
            _view.CloseClicked += OnCloseClicked;
            _view.TimerTicked += OnTimerClicked;
            _view.TransactionClicked += OnTransactionClicked;
            _view.LogoutClicked += OnLogoutClicked;
            _view.ClearCartClicked += OnClearCartClicked;
            _view.SearchProductClicked += OnSearchProductClicked;
            _view.DailySalesClicked += OnDailySalesClicked;
            _view.PaymentClicked += OnPaymentClicked;
        }
        private void OnCloseClicked(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void OnTimerClicked(object? sender, EventArgs e)
        {
            _view.Timer = DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void OnTransactionClicked(object? sender, Button e)
        {
            _view.Slider(e);
            GetTranNo();
        }
        private void OnSearchProductClicked(object? sender, Button e)
        {
            _view.Slider(e);
            SearchProducts searchProducts = new SearchProducts();
            searchProducts.ShowDialog();
        }
        private void OnPaymentClicked(object? sender, Button e)
        {
            _view.Slider(e);
            SettlePayment settlepayment = new SettlePayment();
            settlepayment.txtSale.Text = _view.DisplayTotal;
            settlepayment.ShowDialog();
        }
        private void OnClearCartClicked(object? sender, Button e)
        {
            _view.Slider(e);
        }
        private void OnDailySalesClicked(object? sender, Button e)
        {
            _view.Slider(e);
            DailySale dailySale = new DailySale();
            dailySale.ShowDialog();
        }
        private void OnLogoutClicked(object? sender, Button e)
        {
            _view.Slider(e);
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public void GetTranNo()
        {
            string sdate = DateTime.Now.ToString("yyyyMMdd");
            Guid id = Guid.NewGuid();
            string shortId = id.ToString().Substring(0, 5);
            string transNo = sdate + shortId;
            _view.TransactionNumber = transNo;
        }
    }
}
