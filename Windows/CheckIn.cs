using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelAccounting.Constants;
using HotelAccounting.InMemoryDb;
using HotelAccounting.Models;

namespace HotelAccounting.Windows
{

    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();

            foreach (var room in Rooms.List)
            {
                this.dataGridView1.Rows.Add(room.Type, room.Number, room.NumberOfSeats, room.Price);
            }

            RoomTypesComboBox.Items.Add(Constants.HotelConstants.RoomType[Constants.HotelConstants.RoomTypes.Econom]);
            RoomTypesComboBox.Items.Add(Constants.HotelConstants.RoomType[Constants.HotelConstants.RoomTypes.Standart]);
            RoomTypesComboBox.Items.Add(Constants.HotelConstants.RoomType[Constants.HotelConstants.RoomTypes.Premium]);

            CheckOutDateTimePicker.Value = DateTime.Now.AddDays(1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private RoomModel FindFreeRoom()
        {
            var days = CheckOutDateTimePicker.Value.Day - CheckInDateTimePicker.Value.Day;
            var people = NumberOfPeopleNumericUpDown.Value;
            var keyRoomType = HotelConstants.RoomType.FirstOrDefault(x => x.Value == RoomTypesComboBox.Text).Key;

            RoomModel room = null;

            if(keyRoomType == 0)
            {
                MessageBox.Show("Не вказано тип кімнати.");
                return room;
            }
            
            if(people == 0)
            {
                MessageBox.Show("Не вказано кількість людей на заселення.");
                return room;
            }

                var listOfRoomsByType = Rooms.List.FindAll(x => x.Type.Equals(Constants.HotelConstants.RoomType[(Constants.HotelConstants.RoomTypes)keyRoomType]));

                
                double price = double.MaxValue;

                listOfRoomsByType.ForEach(x =>
                {
                    bool flag = true;

                    Reservations.List.ForEach(y =>
                    {
                        if (y.Room.Number == x.Number)
                            if (((CheckInDateTimePicker.Value < y.DateOut) && (y.DateIn < CheckOutDateTimePicker.Value)))
                                flag = false;
                    });

                    if (flag)
                    {
                        if(x.NumberOfSeats >= people && x.Price * days < price)
                        {
                            price = x.Price * days;
                            room = x;
                        }
                    }
                });

                if(price == double.MaxValue)
                {
                    MessageBox.Show("Немає потрібної кімнати.");
                }
                else
                {
                    PriceLabel.Text = price.ToString();
                    RoomNumberLabel.Text = room.Number;

                    return room;
                }

                return room;
        }

        private void ReservationButton_Click(object sender, EventArgs e)
        {
            var room = FindFreeRoom();
            if( string.IsNullOrWhiteSpace(PIBTextBox.Text) )
                MessageBox.Show("Введіть Прізвище та Ім'я");
            else
            if (room != null)
               Reservations.List.Add(new ReservationModel(PIBTextBox.Text, room, Constants.HotelConstants.ReservationType[Constants.HotelConstants.ReservationTypes.In], CheckInDateTimePicker.Value, CheckOutDateTimePicker.Value, int.Parse(PriceLabel.Text)));
        }

        private void CalculatePriceButton_Click(object sender, EventArgs e)
        {
            FindFreeRoom();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckInDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (this.CheckInDateTimePicker.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Не вірна дата. Має бути не раніше ніж сьогодні.");
                this.CheckInDateTimePicker.Value = DateTime.Now;
            }

            if (this.CheckInDateTimePicker.Value.Date >= this.CheckOutDateTimePicker.Value.Date)
            {
                MessageBox.Show("Дата заселення має бути меншою ніж дата виселення.");
                this.CheckInDateTimePicker.Value = DateTime.Now;
            }
                
        }

        private void CheckOutDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var a = this.RoomTypesComboBox.Text;
            
            if (this.CheckOutDateTimePicker.Value.Date < DateTime.Now.Date.AddDays(1))
            {
                MessageBox.Show("Не вірна дата. Має бути не раніше ніж завтра.");
                this.CheckOutDateTimePicker.Value = DateTime.Now;
            }

            if (this.CheckInDateTimePicker.Value.Date >= this.CheckOutDateTimePicker.Value.Date)
            {
                MessageBox.Show("Дата виселення має бути більшою ніж дата заселення.");
                this.CheckOutDateTimePicker.Value = this.CheckInDateTimePicker.Value;
                this.CheckOutDateTimePicker.Value = this.CheckOutDateTimePicker.Value.AddDays(1);
            }
        }

        private void NumberOfPeopleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckOut f2 = new CheckOut();
            f2.ShowDialog(); // Shows Form2
        }
    }
}
