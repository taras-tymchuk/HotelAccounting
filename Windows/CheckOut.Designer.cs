namespace HotelAccounting.Windows
{
    partial class CheckOut
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
            this.EvictButton = new System.Windows.Forms.Button();
            this.SurnameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SurnameName,
            this.DateIn,
            this.DateOut,
            this.RoomType,
            this.RoomNumber,
            this.TotalPrice});
            this.dataGridView1.Location = new System.Drawing.Point(12, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 339);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EvictButton
            // 
            this.EvictButton.Location = new System.Drawing.Point(559, 384);
            this.EvictButton.Name = "EvictButton";
            this.EvictButton.Size = new System.Drawing.Size(219, 23);
            this.EvictButton.TabIndex = 2;
            this.EvictButton.Text = "Виселити";
            this.EvictButton.UseVisualStyleBackColor = true;
            this.EvictButton.Click += new System.EventHandler(this.EvictButton_Click);
            // 
            // SurnameName
            // 
            this.SurnameName.HeaderText = "Прізвище та Ім\'я";
            this.SurnameName.Name = "SurnameName";
            // 
            // DateIn
            // 
            this.DateIn.HeaderText = "Дата заселення";
            this.DateIn.Name = "DateIn";
            // 
            // DateOut
            // 
            this.DateOut.HeaderText = "Дата виселення";
            this.DateOut.Name = "DateOut";
            // 
            // RoomType
            // 
            this.RoomType.HeaderText = "Тип кімнати";
            this.RoomType.Name = "RoomType";
            // 
            // RoomNumber
            // 
            this.RoomNumber.HeaderText = "Номер кімнати";
            this.RoomNumber.Name = "RoomNumber";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Загальна ціна";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EvictButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EvictButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}