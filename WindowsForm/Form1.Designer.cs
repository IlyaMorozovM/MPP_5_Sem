namespace WindowsForm
{
    partial class FLab1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BSave = new System.Windows.Forms.Button();
            this.BLoad = new System.Windows.Forms.Button();
            this.BAddBook = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPublishingHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDeleteBook = new System.Windows.Forms.Button();
            this.TAuthor = new System.Windows.Forms.TextBox();
            this.TPublishingHouse = new System.Windows.Forms.TextBox();
            this.TYear = new System.Windows.Forms.TextBox();
            this.TISBN = new System.Windows.Forms.TextBox();
            this.TName = new System.Windows.Forms.TextBox();
            this.TPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BDisplay = new System.Windows.Forms.Button();
            this.TDeleteNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BSortName = new System.Windows.Forms.Button();
            this.BSortPrice = new System.Windows.Forms.Button();
            this.BSortAuthor = new System.Windows.Forms.Button();
            this.BSortPublishing = new System.Windows.Forms.Button();
            this.BSortYear = new System.Windows.Forms.Button();
            this.BSortISBN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(870, 8);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(99, 54);
            this.BSave.TabIndex = 0;
            this.BSave.Text = "Save list";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BLoad
            // 
            this.BLoad.Location = new System.Drawing.Point(975, 8);
            this.BLoad.Name = "BLoad";
            this.BLoad.Size = new System.Drawing.Size(98, 54);
            this.BLoad.TabIndex = 1;
            this.BLoad.Text = "Load list";
            this.BLoad.UseVisualStyleBackColor = true;
            this.BLoad.Click += new System.EventHandler(this.BLoad_Click);
            // 
            // BAddBook
            // 
            this.BAddBook.Location = new System.Drawing.Point(27, 104);
            this.BAddBook.Name = "BAddBook";
            this.BAddBook.Size = new System.Drawing.Size(99, 54);
            this.BAddBook.TabIndex = 2;
            this.BAddBook.Text = "Add book";
            this.BAddBook.UseVisualStyleBackColor = true;
            this.BAddBook.Click += new System.EventHandler(this.BAddBook_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CName,
            this.CPrice,
            this.CAuthor,
            this.CPublishingHouse,
            this.CYear,
            this.CISBN,
            this.Number});
            this.dataGridView1.Location = new System.Drawing.Point(27, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1249, 292);
            this.dataGridView1.TabIndex = 3;            // 
            // CName
            // 
            this.CName.HeaderText = "Name";
            this.CName.MinimumWidth = 6;
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            this.CName.Width = 125;
            // 
            // CPrice
            // 
            this.CPrice.HeaderText = "Price";
            this.CPrice.MinimumWidth = 6;
            this.CPrice.Name = "CPrice";
            this.CPrice.ReadOnly = true;
            this.CPrice.Width = 125;
            // 
            // CAuthor
            // 
            this.CAuthor.HeaderText = "Author";
            this.CAuthor.MinimumWidth = 6;
            this.CAuthor.Name = "CAuthor";
            this.CAuthor.ReadOnly = true;
            this.CAuthor.Width = 125;
            // 
            // CPublishingHouse
            // 
            this.CPublishingHouse.HeaderText = "Publishing House";
            this.CPublishingHouse.MinimumWidth = 6;
            this.CPublishingHouse.Name = "CPublishingHouse";
            this.CPublishingHouse.ReadOnly = true;
            this.CPublishingHouse.Width = 125;
            // 
            // CYear
            // 
            this.CYear.HeaderText = "Year";
            this.CYear.MinimumWidth = 6;
            this.CYear.Name = "CYear";
            this.CYear.ReadOnly = true;
            this.CYear.Width = 125;
            // 
            // CISBN
            // 
            this.CISBN.HeaderText = "ISBN";
            this.CISBN.MinimumWidth = 6;
            this.CISBN.Name = "CISBN";
            this.CISBN.ReadOnly = true;
            this.CISBN.Width = 125;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 125;
            // 
            // BDeleteBook
            // 
            this.BDeleteBook.Location = new System.Drawing.Point(1175, 115);
            this.BDeleteBook.Name = "BDeleteBook";
            this.BDeleteBook.Size = new System.Drawing.Size(101, 54);
            this.BDeleteBook.TabIndex = 4;
            this.BDeleteBook.Text = "Delete book";
            this.BDeleteBook.UseVisualStyleBackColor = true;
            this.BDeleteBook.Click += new System.EventHandler(this.BDeleteBook_Click);
            // 
            // TAuthor
            // 
            this.TAuthor.Location = new System.Drawing.Point(333, 76);
            this.TAuthor.Name = "TAuthor";
            this.TAuthor.Size = new System.Drawing.Size(122, 22);
            this.TAuthor.TabIndex = 5;
            // 
            // TPublishingHouse
            // 
            this.TPublishingHouse.Location = new System.Drawing.Point(477, 76);
            this.TPublishingHouse.Name = "TPublishingHouse";
            this.TPublishingHouse.Size = new System.Drawing.Size(122, 22);
            this.TPublishingHouse.TabIndex = 6;
            // 
            // TYear
            // 
            this.TYear.Location = new System.Drawing.Point(617, 76);
            this.TYear.Name = "TYear";
            this.TYear.Size = new System.Drawing.Size(122, 22);
            this.TYear.TabIndex = 7;
            this.TYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TYear_KeyPress);
            // 
            // TISBN
            // 
            this.TISBN.Location = new System.Drawing.Point(745, 76);
            this.TISBN.Name = "TISBN";
            this.TISBN.Size = new System.Drawing.Size(122, 22);
            this.TISBN.TabIndex = 8;
            this.TISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TISBN_KeyPress);
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(27, 76);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(122, 22);
            this.TName.TabIndex = 9;
            // 
            // TPrice
            // 
            this.TPrice.Location = new System.Drawing.Point(175, 76);
            this.TPrice.Name = "TPrice";
            this.TPrice.Size = new System.Drawing.Size(122, 22);
            this.TPrice.TabIndex = 10;
            this.TPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TPrice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Price(in $)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Publishing house";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(742, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "ISBN";
            // 
            // BDisplay
            // 
            this.BDisplay.Location = new System.Drawing.Point(661, 115);
            this.BDisplay.Name = "BDisplay";
            this.BDisplay.Size = new System.Drawing.Size(102, 46);
            this.BDisplay.TabIndex = 17;
            this.BDisplay.Text = "Display books";
            this.BDisplay.UseVisualStyleBackColor = true;
            this.BDisplay.Click += new System.EventHandler(this.BDisplay_Click);
            // 
            // TDeleteNumber
            // 
            this.TDeleteNumber.Location = new System.Drawing.Point(1175, 87);
            this.TDeleteNumber.Name = "TDeleteNumber";
            this.TDeleteNumber.Size = new System.Drawing.Size(101, 22);
            this.TDeleteNumber.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1142, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Number of book to delete";
            // 
            // BSortName
            // 
            this.BSortName.Location = new System.Drawing.Point(85, 173);
            this.BSortName.Name = "BSortName";
            this.BSortName.Size = new System.Drawing.Size(102, 46);
            this.BSortName.TabIndex = 20;
            this.BSortName.Text = "Sort by name";
            this.BSortName.UseVisualStyleBackColor = true;
            this.BSortName.Click += new System.EventHandler(this.BSortName_Click);
            // 
            // BSortPrice
            // 
            this.BSortPrice.Location = new System.Drawing.Point(207, 173);
            this.BSortPrice.Name = "BSortPrice";
            this.BSortPrice.Size = new System.Drawing.Size(102, 46);
            this.BSortPrice.TabIndex = 21;
            this.BSortPrice.Text = "Sort by price";
            this.BSortPrice.UseVisualStyleBackColor = true;
            this.BSortPrice.Click += new System.EventHandler(this.BSortPrice_Click);
            // 
            // BSortAuthor
            // 
            this.BSortAuthor.Location = new System.Drawing.Point(343, 173);
            this.BSortAuthor.Name = "BSortAuthor";
            this.BSortAuthor.Size = new System.Drawing.Size(102, 46);
            this.BSortAuthor.TabIndex = 22;
            this.BSortAuthor.Text = "Sort by author";
            this.BSortAuthor.UseVisualStyleBackColor = true;
            this.BSortAuthor.Click += new System.EventHandler(this.BSortAuthor_Click);
            // 
            // BSortPublishing
            // 
            this.BSortPublishing.Location = new System.Drawing.Point(464, 173);
            this.BSortPublishing.Name = "BSortPublishing";
            this.BSortPublishing.Size = new System.Drawing.Size(102, 46);
            this.BSortPublishing.TabIndex = 23;
            this.BSortPublishing.Text = "Sort by publishing house";
            this.BSortPublishing.UseVisualStyleBackColor = true;
            this.BSortPublishing.Click += new System.EventHandler(this.BSortPublishing_Click);
            // 
            // BSortYear
            // 
            this.BSortYear.Location = new System.Drawing.Point(590, 173);
            this.BSortYear.Name = "BSortYear";
            this.BSortYear.Size = new System.Drawing.Size(102, 46);
            this.BSortYear.TabIndex = 24;
            this.BSortYear.Text = "Sort by year";
            this.BSortYear.UseVisualStyleBackColor = true;
            this.BSortYear.Click += new System.EventHandler(this.BSortYear_Click);
            // 
            // BSortISBN
            // 
            this.BSortISBN.Location = new System.Drawing.Point(709, 173);
            this.BSortISBN.Name = "BSortISBN";
            this.BSortISBN.Size = new System.Drawing.Size(102, 46);
            this.BSortISBN.TabIndex = 25;
            this.BSortISBN.Text = "Sort by ISBN";
            this.BSortISBN.UseVisualStyleBackColor = true;
            this.BSortISBN.Click += new System.EventHandler(this.BSortISBN_Click);
            // 
            // FLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 529);
            this.Controls.Add(this.BSortISBN);
            this.Controls.Add(this.BSortYear);
            this.Controls.Add(this.BSortPublishing);
            this.Controls.Add(this.BSortAuthor);
            this.Controls.Add(this.BSortPrice);
            this.Controls.Add(this.BSortName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TDeleteNumber);
            this.Controls.Add(this.BDisplay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TPrice);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.TISBN);
            this.Controls.Add(this.TYear);
            this.Controls.Add(this.TPublishingHouse);
            this.Controls.Add(this.TAuthor);
            this.Controls.Add(this.BDeleteBook);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BAddBook);
            this.Controls.Add(this.BLoad);
            this.Controls.Add(this.BSave);
            this.Name = "FLab1";
            this.Text = "Lab1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Button BLoad;
        private System.Windows.Forms.Button BAddBook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPublishingHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn CYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn CISBN;
        private System.Windows.Forms.Button BDeleteBook;
        private System.Windows.Forms.TextBox TAuthor;
        private System.Windows.Forms.TextBox TPublishingHouse;
        private System.Windows.Forms.TextBox TYear;
        private System.Windows.Forms.TextBox TISBN;
        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.TextBox TPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BDisplay;
        private System.Windows.Forms.TextBox TDeleteNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BSortName;
        private System.Windows.Forms.Button BSortPrice;
        private System.Windows.Forms.Button BSortAuthor;
        private System.Windows.Forms.Button BSortPublishing;
        private System.Windows.Forms.Button BSortYear;
        private System.Windows.Forms.Button BSortISBN;
    }
}

