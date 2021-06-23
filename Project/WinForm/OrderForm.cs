using InstrumentShop.Models;
using InstrumentShop.RestApiClient;
using System;
using System.Windows.Forms;

namespace InstrumentShop.WinForm
{
    public partial class OrderForm : Form
    {
        private int? orderID;
        private int? instrumentID;
        private bool completed;
        public OrderForm()
        {
            InitializeComponent();
            
        }
        public async void GetOrders()
        {
            orderList.DataSource = (await RestClient.ListOrderNamesAsync());
            completedList.DataSource = orderList.DataSource;
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[orderList.DataSource];
            currencyManager.SuspendBinding();
            foreach (DataGridViewRow row in orderList.Rows)
            {
                if (Convert.ToInt32(row.Cells["Status"].Value) == 1)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
            currencyManager.ResumeBinding();
            currencyManager = (CurrencyManager)BindingContext[completedList.DataSource];
            currencyManager.SuspendBinding();
            foreach (DataGridViewRow row in completedList.Rows)
            {
                Console.WriteLine(row.Cells["Id"].Value.ToString());
                if (Convert.ToInt32(row.Cells["Status"].Value) == 1)
                {
                    row.Visible = false;
                }
                else
                {
                    row.Visible = true;
                }
            }
            currencyManager.ResumeBinding();
        }

        private async void approveButton_Click(object sender, System.EventArgs e)
        {
            if (orderID != null)
            {
                DialogResult result = MessageBox.Show($"Do you want to approve this order {orderID}?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    OrderModel order = await RestClient.GetOrderAsync(orderID);
                    order.Status = 0;
                    await RestClient.UpdateOrderAsync(order);
                    MessageBox.Show("Order Approved", "Success");
                    GetOrders();
                }
                else
                {
                    MessageBox.Show("Process aborted");
                }
            }
        }

        private async void declineButton_Click(object sender, EventArgs e)
        {
            if (orderID != null)
            {
                DialogResult result = MessageBox.Show($"Do you want to decline this order {orderID}?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await RestClient.DeleteOrderAsync((int)orderID);
                    InstrumentModel instrument = await RestClient.GetInstrumentAsync(instrumentID);
                    instrument.QuantityLeft += 1;
                    MessageBox.Show("Order Removed", "Success");
                    GetOrders();
                }
                else
                {
                    MessageBox.Show("Process aborted");
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.UpdateDisplay();
            MainForm.Instance.Show();
            Close();
        }

        private void orderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                orderID = Convert.ToInt32(orderList.Rows[e.RowIndex].Cells["Id"].Value);
                instrumentID = Convert.ToInt32(orderList.Rows[e.RowIndex].Cells["ItemID"].Value);
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            GetOrders();
            if (completed)
            {
                completed = false;
                typeLabel.Text = "Outstanding Orders";
                viewButton.Text = "View Completed";
                approveButton.Enabled = true;
                declineButton.Enabled = true;
                orderList.Visible = true;
                completedList.Visible = false;
                
            }
            else
            {
                completed = true;
                typeLabel.Text = "Completed Orders";
                viewButton.Text = "View Outstanding";
                approveButton.Enabled = false;
                declineButton.Enabled = false;
                orderList.Visible = false;
                completedList.Visible = true;
            }
        }
    }
}
