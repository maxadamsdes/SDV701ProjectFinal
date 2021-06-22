using InstrumentShop.RestApiClient;
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
