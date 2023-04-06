namespace OrdersManagementApp
{
    partial class AddForm
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
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.labelCreateTime = new System.Windows.Forms.Label();
            this.panelOperate = new System.Windows.Forms.Panel();
            this.buttonSaveOrder = new System.Windows.Forms.Button();
            this.buttonDeleteOrderDetail = new System.Windows.Forms.Button();
            this.buttonEditOrderDetail = new System.Windows.Forms.Button();
            this.buttonAddOrderDetail = new System.Windows.Forms.Button();
            this.groupBoxDetail = new System.Windows.Forms.GroupBox();
            this.orderDetailToEditGridView = new System.Windows.Forms.DataGridView();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxInformation.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelOperate.SuspendLayout();
            this.groupBoxDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailToEditGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxInformation.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(1393, 273);
            this.groupBoxInformation.TabIndex = 3;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "基本信息";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxOrderId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxCustomer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCreateTime, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1387, 232);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单号";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "客户";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "下单时间";
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxOrderId.Location = new System.Drawing.Point(292, 17);
            this.textBoxOrderId.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.Size = new System.Drawing.Size(662, 42);
            this.textBoxOrderId.TabIndex = 3;
            this.textBoxOrderId.TextChanged += new System.EventHandler(this.textBoxOrderId_TextChanged);
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Items.AddRange(new object[] {
            "Customer1",
            "Customer2",
            "Customer3",
            "Customer4"});
            this.comboBoxCustomer.Location = new System.Drawing.Point(292, 96);
            this.comboBoxCustomer.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(662, 38);
            this.comboBoxCustomer.TabIndex = 4;
            this.comboBoxCustomer.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomer_SelectedIndexChanged);
            // 
            // labelCreateTime
            // 
            this.labelCreateTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCreateTime.AutoSize = true;
            this.labelCreateTime.Location = new System.Drawing.Point(292, 178);
            this.labelCreateTime.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.labelCreateTime.Name = "labelCreateTime";
            this.labelCreateTime.Size = new System.Drawing.Size(148, 30);
            this.labelCreateTime.TabIndex = 5;
            this.labelCreateTime.Text = "2020-4-10";
            this.labelCreateTime.Click += new System.EventHandler(this.labelCreateTime_Click);
            // 
            // panelOperate
            // 
            this.panelOperate.Controls.Add(this.buttonSaveOrder);
            this.panelOperate.Controls.Add(this.buttonDeleteOrderDetail);
            this.panelOperate.Controls.Add(this.buttonEditOrderDetail);
            this.panelOperate.Controls.Add(this.buttonAddOrderDetail);
            this.panelOperate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOperate.Location = new System.Drawing.Point(0, 813);
            this.panelOperate.Name = "panelOperate";
            this.panelOperate.Size = new System.Drawing.Size(1393, 100);
            this.panelOperate.TabIndex = 4;
            // 
            // buttonSaveOrder
            // 
            this.buttonSaveOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSaveOrder.Location = new System.Drawing.Point(1078, 23);
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
            // buttonAddOrderDetail
            // 
            this.buttonAddOrderDetail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAddOrderDetail.Location = new System.Drawing.Point(27, 23);
            this.buttonAddOrderDetail.Name = "buttonAddOrderDetail";
            this.buttonAddOrderDetail.Size = new System.Drawing.Size(204, 50);
            this.buttonAddOrderDetail.TabIndex = 0;
            this.buttonAddOrderDetail.Text = "添加明细";
            this.buttonAddOrderDetail.UseVisualStyleBackColor = true;
            this.buttonAddOrderDetail.Click += new System.EventHandler(this.buttonAddOrderDetail_Click);
            // 
            // groupBoxDetail
            // 
            this.groupBoxDetail.Controls.Add(this.orderDetailToEditGridView);
            this.groupBoxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDetail.Location = new System.Drawing.Point(0, 273);
            this.groupBoxDetail.Name = "groupBoxDetail";
            this.groupBoxDetail.Size = new System.Drawing.Size(1393, 540);
            this.groupBoxDetail.TabIndex = 5;
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
            this.orderDetailToEditGridView.Size = new System.Drawing.Size(1387, 499);
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
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 913);
            this.Controls.Add(this.groupBoxDetail);
            this.Controls.Add(this.panelOperate);
            this.Controls.Add(this.groupBoxInformation);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.groupBoxInformation.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelOperate.ResumeLayout(false);
            this.groupBoxDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailToEditGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Label labelCreateTime;
        private System.Windows.Forms.Panel panelOperate;
        private System.Windows.Forms.Button buttonSaveOrder;
        private System.Windows.Forms.Button buttonDeleteOrderDetail;
        private System.Windows.Forms.Button buttonEditOrderDetail;
        private System.Windows.Forms.Button buttonAddOrderDetail;
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