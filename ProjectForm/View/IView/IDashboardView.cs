using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.View.IView
{
    public interface IDashboardView
    {
        void ShowDailySales(decimal sales);
        void ShowStocksOnHand(int total);
    }
}
