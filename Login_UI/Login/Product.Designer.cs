namespace Login
{
    partial class Product
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteProducts = new FontAwesome.Sharp.IconButton();
            this.btnAddProducts = new FontAwesome.Sharp.IconButton();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProduct_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnDeleteProducts);
            this.panel1.Controls.Add(this.btnAddProducts);
            this.panel1.Controls.Add(this.comboBoxStatus);
            this.panel1.Controls.Add(this.textBoxProductName);
            this.panel1.Controls.Add(this.textBoxProduct_ID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 516);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(46, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(791, 315);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product_ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            // 
            // btnDeleteProducts
            // 
            this.btnDeleteProducts.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDeleteProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDeleteProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProducts.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDeleteProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProducts.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteProducts.IconColor = System.Drawing.Color.Black;
            this.btnDeleteProducts.IconSize = 32;
            this.btnDeleteProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProducts.Location = new System.Drawing.Point(753, 106);
            this.btnDeleteProducts.Name = "btnDeleteProducts";
            this.btnDeleteProducts.Rotation = 0D;
            this.btnDeleteProducts.Size = new System.Drawing.Size(84, 28);
            this.btnDeleteProducts.TabIndex = 8;
            this.btnDeleteProducts.Text = "Delete";
            this.btnDeleteProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProducts.UseVisualStyleBackColor = true;
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProducts.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProducts.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAddProducts.IconColor = System.Drawing.Color.Black;
            this.btnAddProducts.IconSize = 32;
            this.btnAddProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProducts.Location = new System.Drawing.Point(653, 107);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Rotation = 0D;
            this.btnAddProducts.Size = new System.Drawing.Size(84, 28);
            this.btnAddProducts.TabIndex = 7;
            this.btnAddProducts.Text = "Add";
            this.btnAddProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProducts.UseVisualStyleBackColor = true;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Active",
            "Desactive"});
            this.comboBoxStatus.Location = new System.Drawing.Point(483, 107);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(153, 28);
            this.comboBoxStatus.TabIndex = 6;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.Location = new System.Drawing.Point(255, 109);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(187, 26);
            this.textBoxProductName.TabIndex = 5;
            // 
            // textBoxProduct_ID
            // 
            this.textBoxProduct_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProduct_ID.Location = new System.Drawing.Point(46, 109);
            this.textBoxProduct_ID.Name = "textBoxProduct_ID";
            this.textBoxProduct_ID.Size = new System.Drawing.Size(187, 26);
            this.textBoxProduct_ID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product_ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 45);
            this.panel2.TabIndex = 0;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.ForeColor = System.Drawing.Color.BlueViolet;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton2.IconColor = System.Drawing.Color.Indigo;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(788, 11);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(28, 24);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.Color.BlueViolet;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.Indigo;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(822, 11);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(28, 24);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(862, 516);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnAddProducts;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProduct_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private FontAwesome.Sharp.IconButton btnDeleteProducts;
    }
}