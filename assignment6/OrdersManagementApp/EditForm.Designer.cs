namespace OrdersManagementApp
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelOperate = new System.Windows.Forms.Panel();
            this.buttonSaveOrder = new System.Windows.Forms.Button();
            this.buttonDeleteOrderDetail = new System.Windows.Forms.Button();
            this.buttonEditOrderDetail = new System.Windows.Forms.Button();
            this.AddOrderDetailButton = new System.Windows.Forms.Button();
            this.groupBoxDetail = new System.Windows.Forms.GroupBox();
            this.orderDetailToEditGridView = new System.Windows.Forms.DataGridView();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOperate.SuspendLayout();
            this.groupBoxDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailToEditGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOperate
            // 
            this.panelOperate.Controls.Add(this.buttonSaveOrder);
            this.panelOperate.Controls.Add(this.buttonDeleteOrderDetail);
            this.panelOperate.Controls.Add(this.buttonEditOrderDetail);
            this.panelOperate.Controls.Add(this.AddOrderDetailButton);
            this.panelOperate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOperate.Location = new System.Drawing.Point(0, 960);
            this.panelOperate.Name = "panelOperate";
            this.panelOperate.Size = new System.Drawing.Size(1682, 100);
            this.panelOperate.TabIndex = 1;
            // 
            // buttonSaveOrder
            // 
            this.buttonSaveOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSaveOrder.Location = new System.Drawing.Point(1367, 23);
            this.buttonSaveOrder.Name = "buttonSaveOrder";
            this.buttonSaveOrder.Size = new System.Drawing.Size(204, 50);
            this.buttonSaveOrder.TabIndex = 3;
            this.buttonSaveOrder.Text = "保存订单";
            this.buttonSaveOrder.UseVisualStyleBackColor = true;
            this.buttonSaveOrder.Click += new System.EventHandler(this.buttonSaveOrder_Click);
            // 
            // buttonDeleteOrderDetail
            // 
            this.buttonDeleteOrderDetail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDeleteOrderDetail.Location = new System.Drawing.Point(561, 23);
            this.buttonDeleteOrderDetail.Name = "buttonDeleteOrderDetail";
            this.buttonDeleteOrderDetail.Size = new System.Drawing.Size(204, 50);
            this.buttonDeleteOrderDetail.TabIndex = 2;
            this.buttonDeleteOrderDetail.Text = "删除明细";
            this.buttonDeleteOrderDetail.UseVisualStyleBackColor = true;
            this.buttonDeleteOrderDetail.Click += new System.EventHandler(this.buttonDeleteOrderDetail_Click);
            // 
            // buttonEditOrderDetail
            // 
            this.buttonEditOrderDetail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonEditOrderDetail.Location = new System.Drawing.Point(290, 23);
            this.buttonEditOrderDetail.Name = "buttonEditOrderDetail";
            this.buttonEditOrderDetail.Size = new System.Drawing.Size(204, 50);
            this.buttonEditOrderDetail.TabIndex = 1;
            this.buttonEditOrderDetail.Text = "修改明细";
            this.buttonEditOrderDetail.UseVisualStyleBackColor = true;
            this.buttonEditOrderDetail.Click += new System.EventHandler(this.buttonEditOrderDetail_Click);
            // 
            // AddOrderDetailButton
            // 
            this.AddOrderDetailButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddOrderDetailButton.Location = new System.Drawing.Point(27, 23);
            this.AddOrderDetailButton.Name = "AddOrderDetailButton";
            this.AddOrderDetailButton.Size = new System.Drawing.Size(204, 50);
            this.AddOrderDetailButton.TabIndex = 0;
            this.AddOrderDetailButton.Text = "添加明细";
            this.AddOrderDetailButton.UseVisualStyleBackColor = true;
            this.AddOrderDetailButton.Click += new System.EventHandler(this.buttonAddOrderDetail_Click);
            // 
            // groupBoxDetail
            // 
            this.groupBoxDetail.Controls.Add(this.orderDetailToEditGridView);
            this.groupBoxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDetail.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDetail.Name = "groupBoxDetail";
            this.groupBoxDetail.Size = new System.Drawing.Size(1682, 960);
            this.groupBoxDetail.TabIndex = 3;
            this.groupBoxDetail.TabStop = false;
            this.groupBoxDetail.Text = "订单明细";
            // 
            // orderDetailToEditGridView
            // 
            this.orderDetailToEditGridView.AutoGenerateColumns = false;
            this.orderDetailToEditGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailToEditGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.goodsDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.TotalPrice});
            this.orderDetailToEditGridView.DataSource = this.orderDetailBindingSource;
            this.orderDetailToEditGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDetailToEditGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.orderDetailToEditGridView.Location = new System.Drawing.Point(3, 38);
            this.orderDetailToEditGridView.Name = "orderDetailToEditGridView";
            this.orderDetailToEditGridView.RowHeadersWidth = 102;
            this.orderDetailToEditGridView.RowTemplate.Height = 44;
            this.orderDetailToEditGridView.Size = new System.Drawing.Size(1676, 919);
            this.orderDetailToEditGridView.TabIndex = 0;
            this.orderDetailToEditGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEditOrderDetail_CellContentClick);
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(OrderApp.OrderDetail);
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Number.HeaderText = "序号";
            this.Number.MinimumWidth = 12;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 127;
            // 
            // goodsDataGridViewTextBoxColumn
            // 
            this.goodsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.goodsDataGridViewTextBoxColumn.DataPropertyName = "Goods";
            this.goodsDataGridViewTextBoxColumn.HeaderText = "货物";
            this.goodsDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
            this.goodsDataGridViewTextBoxColumn.Width = 127;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "数量";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 127;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "单价";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 127;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalPrice.HeaderText = "总价";
            this.TotalPrice.MinimumWidth = 12;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 127;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 1060);
            this.Controls.Add(this.groupBoxDetail);
            this.Controls.Add(this.panelOperate);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.panelOperate.ResumeLayout(false);
            this.groupBoxDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailToEditGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelOperate;
        private System.Windows.Forms.Button buttonSaveOrder;
        private System.Windows.Forms.Button buttonDeleteOrderDetail;
        private System.Windows.Forms.Button buttonEditOrderDetail;
        private System.Windows.Forms.Button AddOrderDetailButton;
        private System.Windows.Forms.GroupBox groupBoxDetail;
        private System.Windows.Forms.DataGridView orderDetailToEditGridView;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}