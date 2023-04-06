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
    public partial class MainForm : Form
    {
        
        OrderService orderService = new OrderService();

        //初始化orderService
        public void InitOrders()
        {
            
            //初始化orderService的orders
            Goods apple = new Goods(1, "apple", 10.0f);
            Goods egg = new Goods(2, "egg", 1.2f);
            Goods milk = new Goods(3, "milk", 50f);
            Customer customer1 = new Customer(1, "Customer1");
            Customer customer2 = new Customer(2, "Customer2");
            Order order1 = new Order(1, customer1, new DateTime(2021, 3, 21));
            order1.AddDetails(new OrderDetail(apple, 80));
            order1.AddDetails(new OrderDetail(egg, 200));
            order1.AddDetails(new OrderDetail(milk, 10));
            Order order2 = new Order(2, customer2, new DateTime(2021, 3, 21));
            order2.AddDetails(new OrderDetail(egg, 200));
            order2.AddDetails(new OrderDetail(milk, 10));
            Order order3 = new Order(3, customer2, new DateTime(2021, 3, 21));
            order3.AddDetails(new OrderDetail(apple, 80));
            order3.AddDetails(new OrderDetail(milk, 10));
            orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);

            
        }
        
        
        public MainForm()
        {
            InitializeComponent();

            //初始化orderService
            InitOrders();  //调用初始化函数

            //orderGridView显示orderService的orders中的各order信息
            orderBindingSource.DataSource = orderService.QueryAll();  //orderService的orders
            orderGridView.DataSource = orderBindingSource;  //orderGridView绑定orderBindingSource

            //orderDetailGridView显示orderService的orders中的某一order的details信息
            orderBindingSource1.DataSource = orderBindingSource;  //orderBindingSource1绑定orderBindingSource       

            orderDetailGridView.DataSource = orderBindingSource1;  //orderGridView绑定orderBindingSource1
            orderDetailGridView.DataMember = "Details";  //orderGridView显示order的Details字段



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //orderBindingSource1随orderBindingSource更新
        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            orderBindingSource1.DataSource = orderBindingSource;  //orderBindingSource1绑定orderBindingSource       
            
        }

        private void listBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //单击“添加订单”打开AddForm窗口
        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();

            //以对话框形式打开addForm
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                //利用editForm的order更新orderService的orders
                orderService.AddOrder(addForm.order);
                orderBindingSource.DataSource = orderService.QueryAll();
                addForm.Close();
            }
        }

        private void orderBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        //单击orderGridView时orderDetailGridView显示此订单的订单明细
        //存在需点击-1行才能刷新的问题！！！
        //orderGridView刷新后只能显示刷新前选中的订单的订单明细！！！
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            /*
            if (e.RowIndex == -1||e.ColumnIndex!=0) return;

            DataGridViewCell cell = orderGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

            int currentOrderId = int.Parse(cell.FormattedValue.ToString());
            Order currentOrder = ORDERS.FirstOrDefault(o => o.Id == currentOrderId);
            orderBindingSource1.DataSource = currentOrder;
            orderDetailGridView.DataSource = orderBindingSource1;
            orderDetailGridView.DataMember = "Details";
            */
            /**/
            DataGridViewCell currentCell = orderGridView.CurrentCell;
            //if (e.RowIndex != currentCell.RowIndex || e.ColumnIndex != currentCell.ColumnIndex) return;
            if (currentCell.ColumnIndex == 0)
            {
                int currentOrderId = int.Parse(currentCell.Value.ToString());
                Order currentOrder = orderService.GetById(currentOrderId);
                orderBindingSource1.DataSource = currentOrder;
            }
            
        }


        


        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //点击“查询订单”按钮根据输入更新查询结果
        //按总价查询无法更新！！！
        private void searchOrderButton_Click(object sender, EventArgs e)
        {
            //keyContentTextBox与keyTypeComboBox有空值时显示所有order信息
            if (keyContentTextBox.Text == null|| keyTypeComboBox.SelectedItem == null)
            {
                //orderGridView显示orderService的orders中的各order信息
                orderBindingSource.DataSource = orderService.QueryAll();  //orderBindingSource绑定ORDERS
                
                return;
            }
            //keyContentTextBox与keyTypeComboBox无空值时
            //显示orderService的orders按Id查询的结果
            if (keyTypeComboBox.SelectedItem.ToString() == "订单号")
            {
                int id = int.Parse(keyContentTextBox.Text);
                //orderGridView显示orderService的orders按Id查询的结果
                orderBindingSource.DataSource = orderService.GetById(id);  
                
                return;
            }
            //显示orderService的orders按customerName查询的结果
            if (keyTypeComboBox.SelectedItem.ToString() == "客户名")
            {
                string customerName = keyContentTextBox.Text;
                //orderGridView显示orderService的orders按customerName查询的结果
                orderBindingSource.DataSource = orderService.QueryByCustomerName(customerName);  
                  
                return;
            }
            //显示orderService的orders按goodsName查询的结果
            if (keyTypeComboBox.SelectedItem.ToString() == "货物名")
            {
                string goodsName = keyContentTextBox.Text;
                //orderGridView显示orderService的orders按goodsName查询的结果
                orderBindingSource.DataSource = orderService.QueryByGoodsName(goodsName);  
                  
                return;
            }
            //显示orderService的orders按totalAmount查询的结果
            if (keyTypeComboBox.SelectedItem.ToString() == "总价")
            {
                float totalAmount = float.Parse(keyContentTextBox.Text);
                //orderGridView显示orderService的orders按totalAmount查询的结果
                orderBindingSource.DataSource = orderService.QueryByTotalAmount(totalAmount);  
                 
                return;
            }


        }

        //单击“修改订单”打开EditForm窗口
        private void buttonEditOrder_Click(object sender, EventArgs e)
        {
            DataGridViewCell currentCell = orderGridView.CurrentCell;
            if (currentCell.RowIndex < 0)
            {
                return;
            }

            //将当前选中的order传给editForm
            int currentOrderId = int.Parse(orderGridView.Rows[currentCell.RowIndex].Cells[0].FormattedValue.ToString());
            Order orderToEdit = orderService.GetById(currentOrderId);
            
            EditForm editForm=new EditForm(orderToEdit);

            //以对话框形式打开editForm
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                //利用editForm的order更新orderService的orders
                orderService.Update(editForm.order);
                orderBindingSource.DataSource = orderService.QueryAll();
                editForm.Close();
            }


        }
        //单击“删除订单”删除当前选中的order
        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            DataGridViewCell currentCell = orderGridView.CurrentCell;
            if (currentCell.RowIndex < 0)
            {
                return;
            }

            //将当前选中的order从orderService的orders中删除
            int currentOrderId = int.Parse(orderGridView.Rows[currentCell.RowIndex].Cells[0].FormattedValue.ToString());
            orderService.RemoveOrder(currentOrderId);

            orderBindingSource.DataSource = orderService.QueryAll();

        }
    }
}
