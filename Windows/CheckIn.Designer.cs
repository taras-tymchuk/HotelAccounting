namespace HotelAccounting.Windows
{
    partial class CheckIn
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PIBTextBox = new System.Windows.Forms.TextBox();
            this.CheckInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CheckOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReservationButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RoomTypesComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CalculatePriceButton = new System.Windows.Forms.Button();
            this.RoomNumberLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NumberOfPeopleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPeopleNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomType,
            this.RoomNumber,
            this.NumberOfSeats,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 329);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PIBTextBox
            // 
            this.PIBTextBox.Location = new System.Drawing.Point(32, 377);
            this.PIBTextBox.Name = "PIBTextBox";
            this.PIBTextBox.Size = new System.Drawing.Size(261, 20);
            this.PIBTextBox.TabIndex = 1;
            // 
            // CheckInDateTimePicker
            // 
            this.CheckInDateTimePicker.Location = new System.Drawing.Point(32, 452);
            this.CheckInDateTimePicker.Name = "CheckInDateTimePicker";
            this.CheckInDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.CheckInDateTimePicker.TabIndex = 3;
            this.CheckInDateTimePicker.ValueChanged += new System.EventHandler(this.CheckInDateTimePicker_ValueChanged);
            // 
            // CheckOutDateTimePicker
            // 
            this.CheckOutDateTimePicker.Location = new System.Drawing.Point(32, 495);
            this.CheckOutDateTimePicker.Name = "CheckOutDateTimePicker";
            this.CheckOutDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.CheckOutDateTimePicker.TabIndex = 3;
            this.CheckOutDateTimePicker.ValueChanged += new System.EventHandler(this.CheckOutDateTimePicker_ValueChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(571, 458);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(13, 13);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "_";
            this.PriceLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ціна:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ReservationButton
            // 
            this.ReservationButton.Location = new System.Drawing.Point(329, 492);
            this.ReservationButton.Name = "ReservationButton";
            this.ReservationButton.Size = new System.Drawing.Size(145, 23);
            this.ReservationButton.TabIndex = 5;
            this.ReservationButton.Text = "Заселити";
            this.ReservationButton.UseVisualStyleBackColor = true;
            this.ReservationButton.Click += new System.EventHandler(this.ReservationButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата заселення:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата виселення:";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Прізвище І.Б. особи для рєстрації:";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Кількість осіб";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // RoomTypesComboBox
            // 
            this.RoomTypesComboBox.FormattingEnabled = true;
            this.RoomTypesComboBox.Location = new System.Drawing.Point(449, 377);
            this.RoomTypesComboBox.Name = "RoomTypesComboBox";
            this.RoomTypesComboBox.Size = new System.Drawing.Size(121, 21);
            this.RoomTypesComboBox.TabIndex = 7;
            this.RoomTypesComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Тип кімнати";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // CalculatePriceButton
            // 
            this.CalculatePriceButton.Location = new System.Drawing.Point(329, 452);
            this.CalculatePriceButton.Name = "CalculatePriceButton";
            this.CalculatePriceButton.Size = new System.Drawing.Size(145, 23);
            this.CalculatePriceButton.TabIndex = 5;
            this.CalculatePriceButton.Text = "Розрахувати ціну";
            this.CalculatePriceButton.UseVisualStyleBackColor = true;
            this.CalculatePriceButton.Click += new System.EventHandler(this.CalculatePriceButton_Click);
            // 
            // RoomNumberLabel
            // 
            this.RoomNumberLabel.AutoSize = true;
            this.RoomNumberLabel.Location = new System.Drawing.Point(657, 459);
            this.RoomNumberLabel.Name = "RoomNumberLabel";
            this.RoomNumberLabel.Size = new System.Drawing.Size(13, 13);
            this.RoomNumberLabel.TabIndex = 4;
            this.RoomNumberLabel.Text = "_";
            this.RoomNumberLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(610, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Кімната:";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // NumberOfPeopleNumericUpDown
            // 
            this.NumberOfPeopleNumericUpDown.Location = new System.Drawing.Point(329, 378);
            this.NumberOfPeopleNumericUpDown.Name = "NumberOfPeopleNumericUpDown";
            this.NumberOfPeopleNumericUpDown.Size = new System.Drawing.Size(94, 20);
            this.NumberOfPeopleNumericUpDown.TabIndex = 8;
            this.NumberOfPeopleNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // RoomType
            // 
            this.RoomType.HeaderText = "Тип кімнати";
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            // 
            // RoomNumber
            // 
            this.RoomNumber.HeaderText = "Номер кімнати";
            this.RoomNumber.Name = "RoomNumber";
            // 
            // NumberOfSeats
            // 
            this.NumberOfSeats.HeaderText = "Кількість місць";
            this.NumberOfSeats.Name = "NumberOfSeats";
            // 
            // Price
            // 
            this.Price.HeaderText = "Ціна";
            this.Price.Name = "Price";
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 543);
            this.Controls.Add(this.NumberOfPeopleNumericUpDown);
            this.Controls.Add(this.RoomTypesComboBox);
            this.Controls.Add(this.CalculatePriceButton);
            this.Controls.Add(this.ReservationButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RoomNumberLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.CheckOutDateTimePicker);
            this.Controls.Add(this.CheckInDateTimePicker);
            this.Controls.Add(this.PIBTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CheckIn";
            this.Text = "CheckIn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPeopleNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox PIBTextBox;
        private System.Windows.Forms.DateTimePicker CheckInDateTimePicker;
        private System.Windows.Forms.DateTimePicker CheckOutDateTimePicker;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ReservationButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RoomTypesComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CalculatePriceButton;
        private System.Windows.Forms.Label RoomNumberLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NumberOfPeopleNumericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}