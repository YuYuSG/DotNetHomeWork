namespace OrdersManagementApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchOrderButton = new System.Windows.Forms.Button();
            this.keyContentTextBox = new System.Windows.Forms.TextBox();
            this.keyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonInportOrder = new System.Windows.Forms.Button();
            this.buttonExportOrder = new System.Windows.Forms.Button();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.buttonEditOrder = new System.Windows.Forms.Button();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailGridView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderServiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderServiceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.detailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.detailsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderServiceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderServiceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchOrderButton);
            this.panel1.Controls.Add(this.keyContentTextBox);
            this.panel1.Controls.Add(this.keyTypeComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1734, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // searchOrderButton
            // 
            this.searchOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.searchOrderButton.Location = new System.Drawing.Point(845, 33);
            this.searchOrderButton.Name = "searchOrderButton";
            this.searchOrderButton.Size = new System.Drawing.Size(205, 42);
            this.searchOrderButton.TabIndex = 2;
            this.searchOrderButton.Text = "查询订单";
            this.searchOrderButton.UseVisualStyleBackColor = true;
            this.searchOrderButton.Click += new System.EventHandler(this.searchOrderButton_Click);
            // 
            // keyContentTextBox
            // 
            this.keyContentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.keyContentTextBox.Location = new System.Drawing.Point(334, 33);
            this.keyContentTextBox.Name = "keyContentTextBox";
            this.keyContentTextBox.Size = new System.Drawing.Size(443, 42);
            this.keyContentTextBox.TabIndex = 1;
            this.keyContentTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // keyTypeComboBox
            // 
            this.keyTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.keyTypeComboBox.FormattingEnabled = true;
            this.keyTypeComboBox.Items.AddRange(new object[] {
            "订单号",
            "客户名",
            "货物名",
            "总价"});
            this.keyTypeComboBox.Location = new System.Drawing.Point(29, 33);
            this.keyTypeComboBox.Name = "keyTypeComboBox";
            this.keyTypeComboBox.Size = new System.Drawing.Size(261, 38);
            this.keyTypeComboBox.TabIndex = 0;
            this.keyTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonInportOrder);
            this.panel2.Controls.Add(this.buttonExportOrder);
            this.panel2.Controls.Add(this.buttonDeleteOrder);
            this.panel2.Controls.Add(this.buttonEditOrder);
            this.panel2.Controls.Add(this.buttonAddOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1734, 100);
            this.panel2.TabIndex = 1;
            // 
            // buttonInportOrder
            // 
            this.buttonInportOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInportOrder.Location = new System.Drawing.Point(869, 23);
            this.buttonInportOrder.Name = "buttonInportOrder";
            this.buttonInportOrder.Size = new System.Drawing.Size(181, 58);
            this.buttonInportOrder.TabIndex = 4;
            this.buttonInportOrder.Text = "导入订单";
            this.buttonInportOrder.UseVisualStyleBackColor = true;
            // 
            // buttonExportOrder
            // 
            this.buttonExportOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExportOrder.Location = new System.Drawing.Point(663, 23);
            this.buttonExportOrder.Name = "buttonExportOrder";
            this.buttonExportOrder.Size = new System.Drawing.Size(181, 58);
            this.buttonExportOrder.TabIndex = 3;
            this.buttonExportOrder.Text = "导出订单";
            this.buttonExportOrder.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDeleteOrder.Location = new System.Drawing.Point(450, 23);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(181, 58);
            this.buttonDeleteOrder.TabIndex = 2;
            this.buttonDeleteOrder.Text = "删除订单";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // buttonEditOrder
            // 
            this.buttonEditOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonEditOrder.Location = new System.Drawing.Point(240, 23);
            this.buttonEditOrder.Name = "buttonEditOrder";
            this.buttonEditOrder.Size = new System.Drawing.Size(181, 58);
            this.buttonEditOrder.TabIndex = 1;
            this.buttonEditOrder.Text = "修改订单";
            this.buttonEditOrder.UseVisualStyleBackColor = true;
            this.buttonEditOrder.Click += new System.EventHandler(this.buttonEditOrder_Click);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAddOrder.Location = new System.Drawing.Point(29, 23);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(181, 58);
            this.buttonAddOrder.TabIndex = 0;
            this.buttonAddOrder.Text = "添加订单";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 600);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1734, 62);
            this.panel3.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 200);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.orderGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.orderDetailGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1734, 400);
            this.splitContainer1.SplitterDistance = 855;
            this.splitContainer1.TabIndex = 3;
            // 
            // orderGridView
            // 
            this.orderGridView.AutoGenerateColumns = false;
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn});
            this.orderGridView.DataSource = this.orderBindingSource;
            this.orderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.orderGridView.Location = new System.Drawing.Point(0, 0);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.RowHeadersWidth = 102;
            this.orderGridView.RowTemplate.Height = 30;
            this.orderGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderGridView.Size = new System.Drawing.Size(855, 400);
            this.orderGridView.TabIndex = 0;
            this.orderGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "订单号";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 157;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "客户";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 127;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "下单时间";
            this.createTimeDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.Width = 187;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "总价";
            this.totalAmountDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalAmountDataGridViewTextBoxColumn.Width = 127;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderApp.Order);
            this.orderBindingSource.CurrentChanged += new System.EventHandler(this.orderBindingSource_CurrentChanged_1);
            // 
            // orderDetailGridView
            // 
            this.orderDetailGridView.AutoGenerateColumns = false;
            this.orderDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.goodsDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.orderDetailGridView.DataMember = "Details";
            this.orderDetailGridView.DataSource = this.orderBindingSource1;
            this.orderDetailGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDetailGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.orderDetailGridView.Location = new System.Drawing.Point(0, 0);
            this.orderDetailGridView.Name = "orderDetailGridView";
            this.orderDetailGridView.RowHeadersWidth = 102;
            this.orderDetailGridView.RowTemplate.Height = 30;
            this.orderDetailGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDetailGridView.Size = new System.Drawing.Size(875, 400);
            this.orderDetailGridView.TabIndex = 1;
            this.orderDetailGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderDetail_CellContentClick);
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Number.HeaderText = "序号";
            this.Number.MinimumWidth = 12;
            this.Number.Name = "Number";
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
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataSource = typeof(OrderApp.Order);
            // 
            // orderServiceBindingSource1
            // 
            this.orderServiceBindingSource1.DataSource = typeof(OrderApp.OrderService);
            // 
            // orderServiceBindingSource2
            // 
            this.orderServiceBindingSource2.DataSource = typeof(OrderApp.OrderService);
            // 
            // detailsBindingSource2
            // 
            this.detailsBindingSource2.DataMember = "Details";
            this.detailsBindingSource2.DataSource = this.orderBindingSource;
            // 
            // detailsBindingSource3
            // 
            this.detailsBindingSource3.DataMember = "Details";
            this.detailsBindingSource3.DataSource = this.orderBindingSource;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(OrderApp.OrderDetail);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 662);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderServiceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderServiceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox keyTypeComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox keyContentTextBox;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Button buttonEditOrder;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Button searchOrderButton;
        private System.Windows.Forms.Button buttonInportOrder;
        private System.Windows.Forms.Button buttonExportOrder;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.BindingSource orderServiceBindingSource1;
        private System.Windows.Forms.BindingSource orderServiceBindingSource2;
        private System.Windows.Forms.BindingSource detailsBindingSource2;
        private System.Windows.Forms.DataGridView orderDetailGridView;
        private System.Windows.Forms.BindingSource detailsBindingSource3;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource1;
    }
}

