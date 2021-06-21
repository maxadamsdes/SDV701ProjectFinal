using InstrumentShop.RestApiClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstrumentShop.WinForm
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        public async void GetOrders()
        {
            orderList.DataSource = (await RestClient.ListOrderNamesAsync());
        }
    }
}
