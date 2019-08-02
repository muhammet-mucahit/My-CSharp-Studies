namespace Information_System_for_Hotels
{
    partial class FrmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Food = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Drink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Snack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSave2 = new System.Windows.Forms.Button();
            this.TxtFood = new System.Windows.Forms.TextBox();
            this.TxtInternet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtWater = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtElectric = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDrink = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSnack = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtElectric1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSave1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtInternet1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtWater1 = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Food,
            this.Drink,
            this.Snack});
            this.listView1.Location = new System.Drawing.Point(2, 257);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(330, 110);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Food
            // 
            this.Food.Text = "Food";
            this.Food.Width = 99;
            // 
            // Drink
            // 
            this.Drink.Text = "Drink";
            this.Drink.Width = 103;
            // 
            // Snack
            // 
            this.Snack.Text = "Snack";
            this.Snack.Width = 96;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSave2);
            this.groupBox1.Controls.Add(this.TxtFood);
            this.groupBox1.Controls.Add(this.TxtInternet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtWater);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtElectric);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtDrink);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtSnack);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 239);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock of Kitchen";
            // 
            // BtnSave2
            // 
            this.BtnSave2.Location = new System.Drawing.Point(451, 161);
            this.BtnSave2.Name = "BtnSave2";
            this.BtnSave2.Size = new System.Drawing.Size(100, 23);
            this.BtnSave2.TabIndex = 31;
            this.BtnSave2.Text = "Save";
            this.BtnSave2.UseVisualStyleBackColor = true;
            // 
            // TxtFood
            // 
            this.TxtFood.Location = new System.Drawing.Point(154, 51);
            this.TxtFood.Name = "TxtFood";
            this.TxtFood.Size = new System.Drawing.Size(100, 20);
            this.TxtFood.TabIndex = 21;
            // 
            // TxtInternet
            // 
            this.TxtInternet.Location = new System.Drawing.Point(451, 111);
            this.TxtInternet.Name = "TxtInternet";
            this.TxtInternet.Size = new System.Drawing.Size(100, 20);
            this.TxtInternet.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Food Amount = ";
            // 
            // TxtWater
            // 
            this.TxtWater.Location = new System.Drawing.Point(451, 83);
            this.TxtWater.Name = "TxtWater";
            this.TxtWater.Size = new System.Drawing.Size(100, 20);
            this.TxtWater.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Drink Amount = ";
            // 
            // TxtElectric
            // 
            this.TxtElectric.Location = new System.Drawing.Point(451, 51);
            this.TxtElectric.Name = "TxtElectric";
            this.TxtElectric.Size = new System.Drawing.Size(100, 20);
            this.TxtElectric.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Snack Amount = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Internet";
            // 
            // TxtDrink
            // 
            this.TxtDrink.Location = new System.Drawing.Point(154, 83);
            this.TxtDrink.Name = "TxtDrink";
            this.TxtDrink.Size = new System.Drawing.Size(100, 20);
            this.TxtDrink.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Water = ";
            // 
            // TxtSnack
            // 
            this.TxtSnack.Location = new System.Drawing.Point(154, 111);
            this.TxtSnack.Name = "TxtSnack";
            this.TxtSnack.Size = new System.Drawing.Size(100, 20);
            this.TxtSnack.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Electric = ";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(154, 161);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 23);
            this.BtnSave.TabIndex = 24;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtElectric1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.BtnSave1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TxtInternet1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtWater1);
            this.groupBox2.Location = new System.Drawing.Point(338, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 239);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoices";
            // 
            // TxtElectric1
            // 
            this.TxtElectric1.Location = new System.Drawing.Point(141, 51);
            this.TxtElectric1.Name = "TxtElectric1";
            this.TxtElectric1.Size = new System.Drawing.Size(100, 20);
            this.TxtElectric1.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Electric = ";
            // 
            // BtnSave1
            // 
            this.BtnSave1.Location = new System.Drawing.Point(141, 161);
            this.BtnSave1.Name = "BtnSave1";
            this.BtnSave1.Size = new System.Drawing.Size(100, 23);
            this.BtnSave1.TabIndex = 38;
            this.BtnSave1.Text = "Save";
            this.BtnSave1.UseVisualStyleBackColor = true;
            this.BtnSave1.Click += new System.EventHandler(this.BtnSave1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Water = ";
            // 
            // TxtInternet1
            // 
            this.TxtInternet1.Location = new System.Drawing.Point(141, 111);
            this.TxtInternet1.Name = "TxtInternet1";
            this.TxtInternet1.Size = new System.Drawing.Size(100, 20);
            this.TxtInternet1.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Internet = ";
            // 
            // TxtWater1
            // 
            this.TxtWater1.Location = new System.Drawing.Point(141, 83);
            this.TxtWater1.Name = "TxtWater1";
            this.TxtWater1.Size = new System.Drawing.Size(100, 20);
            this.TxtWater1.TabIndex = 36;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.Location = new System.Drawing.Point(338, 257);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(330, 110);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Electric";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Water";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Internet";
            this.columnHeader3.Width = 96;
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(672, 369);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Food;
        private System.Windows.Forms.ColumnHeader Drink;
        private System.Windows.Forms.ColumnHeader Snack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSave2;
        private System.Windows.Forms.TextBox TxtFood;
        private System.Windows.Forms.TextBox TxtInternet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtWater;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtElectric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDrink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSnack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtElectric1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSave1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtInternet1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtWater1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}