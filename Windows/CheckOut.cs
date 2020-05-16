using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelAccounting.InMemoryDb;

namespace HotelAccounting.Windows
{
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
            foreach(var reservation in Reservations.List)
            {

                if (reservation.Type == Constants.HotelConstants.ReservationType[Constants.HotelConstants.ReservationTypes.In])
                    this.dataGridView1.Rows.Add(reservation.NameOfPerson, reservation.DateIn, reservation.DateOut, reservation.Type, reservation.Room.Number, reservation.TotalPrice);
            }
        }
        // виселино
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EvictButton_Click(object sender, EventArgs e)
        {
            var selectedCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if(selectedCount==0)
                MessageBox.Show("Виберіть рядок для видалення.");
            else
            {
                string room = "";
                DateTime dateIn = DateTime.Now;
                DateTime dateOut = DateTime.Now;

                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    if(row.Selected)
                    {
                        foreach(DataGridViewCell cell in row.Cells)
                        {
                            int columnIndex = cell.ColumnIndex;
                            string columnName = dataGridView1.Columns[columnIndex].Name;

                            if(columnName == "DateIn")
                            {
                                dateIn = (DateTime)cell.Value;
                            }
                            else if(columnName == "DateOut")
                            {
                                dateOut = (DateTime)cell.Value;
                            }
                            else if(columnName == "RoomNumber")
                            {
                                room = (string)cell.Value;
                            }
                        }
                    }
                }

                Reservations.List.ForEach(x =>
                {
                    if(x.DateIn.Date == dateIn.Date && x.DateOut.Date == dateOut.Date && x.Room.Number == room)
                    {
                        x.Type = Constants.HotelConstants.ReservationType[Constants.HotelConstants.ReservationTypes.Out];
                    }
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
