
namespace CarOder2._0
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.KmBox = new System.Windows.Forms.TextBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.InfoPrice = new System.Windows.Forms.TextBox();
            this.InfoYear = new System.Windows.Forms.TextBox();
            this.InfoKm = new System.Windows.Forms.TextBox();
            this.InfoColor = new System.Windows.Forms.TextBox();
            this.InfoMake = new System.Windows.Forms.TextBox();
            this.InfoId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.InfoModel = new System.Windows.Forms.TextBox();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(37, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 340);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Year";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(389, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(389, 104);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(155, 132);
            this.listBox2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(410, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Edit Cars";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(413, 325);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(108, 22);
            this.IDBox.TabIndex = 10;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(415, 374);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(107, 22);
            this.PriceBox.TabIndex = 11;
            this.PriceBox.TextChanged += new System.EventHandler(this.PriceBox_TextChanged);
            // 
            // KmBox
            // 
            this.KmBox.Location = new System.Drawing.Point(415, 402);
            this.KmBox.Name = "KmBox";
            this.KmBox.Size = new System.Drawing.Size(107, 22);
            this.KmBox.TabIndex = 12;
            this.KmBox.TextChanged += new System.EventHandler(this.KmBox_TextChanged);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(528, 310);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(107, 37);
            this.EditBtn.TabIndex = 13;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Km";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(528, 385);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(107, 39);
            this.SaveBtn.TabIndex = 16;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(413, 283);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(107, 36);
            this.listBox3.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(32, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "Car list";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(231, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "Car info";
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(641, 310);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(107, 37);
            this.BtnRemove.TabIndex = 20;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // InfoPrice
            // 
            this.InfoPrice.Location = new System.Drawing.Point(265, 204);
            this.InfoPrice.Name = "InfoPrice";
            this.InfoPrice.Size = new System.Drawing.Size(100, 22);
            this.InfoPrice.TabIndex = 21;
            // 
            // InfoYear
            // 
            this.InfoYear.Location = new System.Drawing.Point(265, 232);
            this.InfoYear.Name = "InfoYear";
            this.InfoYear.Size = new System.Drawing.Size(100, 22);
            this.InfoYear.TabIndex = 22;
            // 
            // InfoKm
            // 
            this.InfoKm.Location = new System.Drawing.Point(265, 176);
            this.InfoKm.Name = "InfoKm";
            this.InfoKm.Size = new System.Drawing.Size(100, 22);
            this.InfoKm.TabIndex = 23;
            // 
            // InfoColor
            // 
            this.InfoColor.Location = new System.Drawing.Point(265, 148);
            this.InfoColor.Name = "InfoColor";
            this.InfoColor.Size = new System.Drawing.Size(100, 22);
            this.InfoColor.TabIndex = 24;
            // 
            // InfoMake
            // 
            this.InfoMake.Location = new System.Drawing.Point(265, 92);
            this.InfoMake.Name = "InfoMake";
            this.InfoMake.Size = new System.Drawing.Size(100, 22);
            this.InfoMake.TabIndex = 25;
            // 
            // InfoId
            // 
            this.InfoId.Location = new System.Drawing.Point(265, 64);
            this.InfoId.Name = "InfoId";
            this.InfoId.Size = new System.Drawing.Size(100, 22);
            this.InfoId.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(218, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(217, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Make";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(218, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Model";
            // 
            // InfoModel
            // 
            this.InfoModel.Location = new System.Drawing.Point(265, 120);
            this.InfoModel.Name = "InfoModel";
            this.InfoModel.Size = new System.Drawing.Size(100, 22);
            this.InfoModel.TabIndex = 30;
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Location = new System.Drawing.Point(265, 260);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(107, 37);
            this.BtnAddNew.TabIndex = 31;
            this.BtnAddNew.Text = "Add new car";
            this.BtnAddNew.UseVisualStyleBackColor = true;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 445);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.InfoModel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.InfoId);
            this.Controls.Add(this.InfoMake);
            this.Controls.Add(this.InfoColor);
            this.Controls.Add(this.InfoKm);
            this.Controls.Add(this.InfoYear);
            this.Controls.Add(this.InfoPrice);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.KmBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Cars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox KmBox;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.TextBox InfoPrice;
        private System.Windows.Forms.TextBox InfoYear;
        private System.Windows.Forms.TextBox InfoKm;
        private System.Windows.Forms.TextBox InfoColor;
        private System.Windows.Forms.TextBox InfoMake;
        private System.Windows.Forms.TextBox InfoId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox InfoModel;
        private System.Windows.Forms.Button BtnAddNew;
    }
}

