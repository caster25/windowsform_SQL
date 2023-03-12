namespace Tast02.Foms
{
    partial class FormProducts
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
            this.checkProduct = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntProduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkProduct
            // 
            this.checkProduct.AutoSize = true;
            this.checkProduct.Location = new System.Drawing.Point(45, 190);
            this.checkProduct.Name = "checkProduct";
            this.checkProduct.Size = new System.Drawing.Size(55, 20);
            this.checkProduct.TabIndex = 41;
            this.checkProduct.Text = "ยืนยัน";
            this.checkProduct.UseVisualStyleBackColor = true;
            this.checkProduct.CheckedChanged += new System.EventHandler(this.checkProduct_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "ตัวอย่าง";
            // 
            // textNum
            // 
            this.textNum.Location = new System.Drawing.Point(45, 143);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(169, 22);
            this.textNum.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 112);
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
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "รายการ ID";
            // 
            // bntProduct
            // 
            this.bntProduct.Location = new System.Drawing.Point(45, 253);
            this.bntProduct.Name = "bntProduct";
            this.bntProduct.Size = new System.Drawing.Size(124, 55);
            this.bntProduct.TabIndex = 28;
            this.bntProduct.Text = "SAVE";
            this.bntProduct.UseVisualStyleBackColor = true;
            this.bntProduct.Click += new System.EventHandler(this.bntProduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tast02.Properties.Resources._577280151_1;
            this.pictureBox1.Location = new System.Drawing.Point(269, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // comboID
            // 
            this.comboID.FormattingEnabled = true;
            this.comboID.Items.AddRange(new object[] {
            "1111:สินค้า1",
            "1112:สินค้า2",
            "1113:สินค้า3",
            "1114:สินค้า4",
            "1115:สินค้า5",
            "1116:สินค้า6",
            "1117:สินค้า7",
            "1118:สินค้า8",
            "1119:สินค้า9"});
            this.comboID.Location = new System.Drawing.Point(45, 69);
            this.comboID.Name = "comboID";
            this.comboID.Size = new System.Drawing.Size(169, 24);
            this.comboID.TabIndex = 43;
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntProduct);
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboID;
    }
}