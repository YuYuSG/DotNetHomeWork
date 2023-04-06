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
    public partial class EditForm : Form
    {

        public Order order = new Order();
        
        public EditForm()
        {
            InitializeComponent();

            //orderDetailToEditGridView显示order的订单明细
            orderDetailBindingSource.DataSource = order.Details;  //orderDetailBindingSource绑定order的details
            orderDetailToEditGridView.DataSource = orderDetailBindingSource;  //orderDetailToEditGridView绑定orderDetailBindingSource

        }

        //创建EditForm时传递要修改的订单
        //无法显示单击“修改订单”前选中的订单的订单明细!!!
        public EditForm(Order orderToEdit)
        {
            InitializeComponent();

            //将要修改的订单浅拷贝至order
            order.Id = orderToEdit.Id;
            order.Customer = orderToEdit.Customer;
            order.CreateTime = orderToEdit.CreateTime;

            //orderDetailToEditGridView显示order的订单明细
            orderDetailBindingSource.DataSource = order.Details;  //orderDetailBindingSource绑定order的details
            orderDetailToEditGridView.DataSource = orderDetailBindingSource;  //orderDetailToEditGridView绑定orderDetailBindingSource


        }

        //单击orderDetailToEditGridView单元格
        //数据异常!!!
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
            int quantity= int.Parse(orderDetailToEditGridView.Rows[currentCell.RowIndex].Cells[2].FormattedValue.ToString());

            Goods goods = new Goods(id, goodsName, price);
            OrderDetail orderDetail = new OrderDetail(goods, quantity);
            order.AddDetails(orderDetail);
            orderDetailBindingSource.DataSource = order.Details;
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
        //单击“保存订单”结束修改订单操作
        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;

        }
        //单击“修改明细”修改当前行的orderDetail
        //由于设置orderDetailToEdit可修改，不知道单击此按钮时需进行什么操作
        private void buttonEditOrderDetail_Click(object sender, EventArgs e)
        {

        }
    }
}
