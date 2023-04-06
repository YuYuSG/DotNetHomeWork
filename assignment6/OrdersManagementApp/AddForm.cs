using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;

namespace OrdersManagementApp
{
    public partial class AddForm : Form
    {

        public Order order = new Order();
       

        public AddForm()
        {
            InitializeComponent();

            labelCreateTime.Text = DateTime.Now.ToString();

            //orderDetailToEditGridView显示order的订单明细
            orderDetailBindingSource.DataSource = order.Details;  //orderDetailBindingSource绑定order的details
            orderDetailToEditGridView.DataSource = orderDetailBindingSource;  //orderDetailToEditGridView绑定orderDetailBindingSource
        }

        private void dataGridViewEditOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //单击“添加明细”根据当前行的单元格内容创建orderdetail并添加至order
        private void buttonAddOrderDetail_Click(object sender, EventArgs e)
        {
            DataGridViewCell currentCell = orderDetailToEditGridView.CurrentCell;
            if (currentCell.RowIndex < 0) { return; }
            int id = currentCell.RowIndex;
            string goodsName = orderDetailToEditGridView.Rows[currentCell.RowIndex].Cells[1].FormattedValue.ToString();
            float price = float.Parse(orderDetailToEditGridView.Rows[currentCell.RowIndex].Cells[3].FormattedValue.ToString());
            int quantity = int.Parse(orderDetailToEditGridView.Rows[currentCell.RowIndex].Cells[2].FormattedValue.ToString());

            Goods goods = new Goods(id, goodsName, price);
            OrderDetail orderDetail = new OrderDetail(goods, quantity);
            order.AddDetails(orderDetail);
            orderDetailBindingSource.DataSource = order.Details;
        }
        //单击“修改明细”修改当前行的orderDetail
        //由于设置orderDetailToEdit可修改，不知道单击此按钮时需进行什么操作
        private void buttonEditOrderDetail_Click(object sender, EventArgs e)
        {

        }
        //单击“删除明细”在order中删除当前行对应的orderdetail
        private void buttonDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            DataGridViewCell currentCell = orderDetailToEditGridView.CurrentCell;
            if (currentCell.RowIndex < 0) { return; }
            int num = currentCell.RowIndex;
            order.RemoveDetails(num);
            orderDetailBindingSource.DataSource = order.Details;
        }
        //单击“保存订单”将order添加至orderService的orders中
        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        //根据用户输入的订单号修改order的Id
        private void textBoxOrderId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxOrderId.Text == null) { return; }
            int id = int.Parse(textBoxOrderId.Text);
            order.Id = id;
        }
        //根据用户选择的顾客修改order的Customer
        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCustomer.SelectedItem == null) { return; }
            if (comboBoxCustomer.SelectedItem.ToString() == "Customer1")
            {
                Customer customer = new Customer(1, "Customer1");
                order.Customer = customer;
                return;
            }
            if (comboBoxCustomer.SelectedItem.ToString() == "Customer2")
            {
                Customer customer = new Customer(2, "Customer2");
                order.Customer = customer;
                return;
            }
            if (comboBoxCustomer.SelectedItem.ToString() == "Customer3")
            {
                Customer customer = new Customer(3, "Customer3");
                order.Customer = customer;
                return;
            }
            if (comboBoxCustomer.SelectedItem.ToString() == "Customer4")
            {
                Customer customer = new Customer(4, "Customer4");
                order.Customer = customer;
                return;
            }

        }

        private void labelCreateTime_Click(object sender, EventArgs e)
        {
            
        }
    }
}
