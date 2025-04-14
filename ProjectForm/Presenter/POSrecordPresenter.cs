using ProjectForm.Model.DTOs;
using ProjectForm.View.IView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ProjectForm.Presenter
{
    public class POSrecordPresenter
    {
        private readonly IPOSrecordView _view;
        private readonly POSrecord _pOSrecord;
        public POSrecordPresenter(IPOSrecordView view, POSrecord pOSrecord)
        {
            _view = view;
            _pOSrecord = pOSrecord;
        }

        public async Task LoadDataAsync(string name, DateOnly startDate, DateOnly endDate, string selecteditem)
        {
            
            if(startDate > endDate || endDate < startDate)
            {
                MessageBox.Show("Invalid Date");
                return;
            }

            if (selecteditem == string.Empty)
            {
                MessageBox.Show("Please select sort type.");
                return;
            }

            string dateTo = startDate.ToString("MM-dd-yyyy");
            string dateFrom = endDate.ToString("MM-dd-yyyy");
            string newSelectedItem = selecteditem.Replace(" ", "");
            
            if (name == "btnLoad")
            {
                //this is for top selling items
                 _pOSrecord.selectedComboBox= string.Empty;

            }
            else if(name == "btnLoadSolditem")
            {
                //this is for sold items
                _pOSrecord.selectedComboBox = string.Empty;
            }
            else if(name == "btnLoadstockin")
            {
                //this is for stock in history
                _pOSrecord.selectedComboBox = string.Empty;
            }
        }

        //public async Task<List<POSrecordDto1>> LoadTopSellingAsync(string startDate, string endDate, string selectedItem)
        //{
            
        //}
    }
}
