namespace Tast02.Foms
{
    partial class FormCustomers
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
            this.checkCustomer = new System.Windows.Forms.CheckBox();
            this.textNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntCustomer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.txtSearch1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkCustomer
            // 
            this.checkCustomer.AutoSize = true;
            this.checkCustomer.Location = new System.Drawing.Point(44, 255);
            this.checkCustomer.Name = "checkCustomer";
            this.checkCustomer.Size = new System.Drawing.Size(55, 20);
            this.checkCustomer.TabIndex = 41;
            this.checkCustomer.Text = "ยืนยัน";
            this.checkCustomer.UseVisualStyleBackColor = true;
            this.checkCustomer.CheckedChanged += new System.EventHandler(this.checkCustomer_CheckedChanged);
            // 
            // textNum
            // 
            this.textNum.Location = new System.Drawing.Point(43, 219);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(169, 22);
            this.textNum.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "จำนวน";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID";
            // 
            // bntCustomer
            // 
            this.bntCustomer.Location = new System.Drawing.Point(44, 306);
            this.bntCustomer.Name = "bntCustomer";
            this.bntCustomer.Size = new System.Drawing.Size(124, 55);
            this.bntCustomer.TabIndex = 28;
            this.bntCustomer.Text = "UPDATE";
            this.bntCustomer.UseVisualStyleBackColor = true;
            this.bntCustomer.Click += new System.EventHandler(this.bntCustomer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(326, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(435, 293);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Products";
            this.Column2.HeaderText = "Products";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Quantity";
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Time";
            this.Column4.HeaderText = "Time";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "รายการ";
            // 
            // comboCustomer
            // 
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Items.AddRange(new object[] {
            "1111:สินค้า1",
            "1112:สินค้า2",
            "1113:สินค้า3",
            "1114:สินค้า4",
            "1115:สินค้า5",
            "1116:สินค้า6",
            "1117:สินค้า7",
            "1118:สินค้า8",
            "1119:สินค้า9"});
            this.comboCustomer.Location = new System.Drawing.Point(45, 146);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(167, 24);
            this.comboCustomer.TabIndex = 47;
            // 
            // txtSearch1
            // 
            this.txtSearch1.Location = new System.Drawing.Point(43, 68);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.Size = new System.Drawing.Size(169, 22);
            this.txtSearch1.TabIndex = 48;
            this.txtSearch1.TextChanged += new System.EventHandler(this.textSaerch1_TextChanged);
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch1);
            this.Controls.Add(this.comboCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkCustomer);
            this.Controls.Add(this.textNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntCustomer);
            this.Name = "FormCustomers";
            this.Text = "FormCustomers";
            this.Shown += new System.EventHandler(this.FormCustomers_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkCustomer;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.TextBox txtSearch1;
    }
}