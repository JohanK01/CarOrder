using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarOder2._0
{
    public partial class Form1 : Form
    {
        List<Car> Cars;
        public Form1()
        {
            InitializeComponent();
            Cars = new List<Car>();
            ListOfCars(); // Calls for the class with the cars


            //Show all cars A-Z
            foreach (Car c in Cars.OrderBy(x => x.Make))
            {
                listBox1.Items.Add(c);
            }
            //Combo box
            comboBox1.Text = "Välj en färg!";
            foreach (string c in Cars.Select(x => x.Color).Distinct())
            {
                comboBox1.Items.Add(c);
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Will be able to click an item in the listbox
            ListBox listofCars = sender as ListBox;
            Car selectedCar = listofCars.SelectedItem as Car;
            //Shows the info of a car
            InfoId.Text = $"{selectedCar.Id}";
            InfoMake.Text = $"{selectedCar.Make}";
            InfoModel.Text = $"{selectedCar.Model}";
            InfoColor.Text = $"{selectedCar.Color}";
            InfoKm.Text = $"{selectedCar.Km}";
            InfoPrice.Text = $"{selectedCar.Price} kr";
            InfoYear.Text = $"{selectedCar.Year}";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Finds cars with the selected colors in combobox
            string ComboColors = (sender as ComboBox).SelectedItem as string;
            listBox2.Items.Clear();
            foreach (var cc in Cars.FindAll(x => x.Color == ComboColors))
            {
                listBox2.Items.Add(cc);
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            listBox3.Items.Clear();
            int FindID = int.Parse(IDBox.Text);
            foreach (var Ic in Cars.FindAll(x => x.Id == FindID))
            {
                listBox3.Items.Add(Ic);

            }

        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //Finds the car with the Id
            int FindID = int.Parse(IDBox.Text);
            int PriceChange = int.Parse(PriceBox.Text);
            int KmChange = int.Parse(KmBox.Text);

            //Finds the car with the id and goes to the price and changes it
            Cars.Find(x => x.Id == FindID).Price = PriceChange;
            Cars.Find(x => x.Id == FindID).Km = KmChange;


        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            //Finds the car from the ID put in
            int Position = Cars.FindIndex(x => x.Id == int.Parse(IDBox.Text));

            //Removes the car but doesnt refresh the list
            Cars.RemoveAt(Position);

            //Removes the list and then re-writes it
            listBox1.Items.Clear();
            foreach (Car c in Cars.OrderBy(x => x.Make))
            {
                listBox1.Items.Add(c);
            }
        }
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            //reads the list and adds a car
            Cars.Add(new Car() { Id = int.Parse(InfoId.Text), Make = InfoMake.Text, Model = InfoModel.Text, Color = InfoColor.Text, Km = int.Parse(InfoKm.Text), Price = int.Parse(InfoPrice.Text), Year = int.Parse(InfoYear.Text) });
            //removes the whole list and adds it again
            listBox1.Items.Clear();
            foreach (Car c in Cars.OrderBy(x => x.Make))
            {
                listBox1.Items.Add(c);
            }
        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KmBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void ListOfCars()
        {
            Cars.Add(new Car() { Id = 1, Make = "Volvo", Model = "V70", Color = "White", Km = 1292, Price = 3465, Year = 1998 });
            Cars.Add(new Car() { Id = 31, Make = "Skoda", Model = "Fabia", Color = "Red", Km = 1292, Price = 76556, Year = 2001 });
            Cars.Add(new Car() { Id = 14, Make = "Volvo", Model = "XC90", Color = "Blue", Km = 432, Price = 32001, Year = 2003 });
            Cars.Add(new Car() { Id = 4, Make = "Volvo", Model = "V70", Color = "Red", Km = 1223492, Price = 24512, Year = 1998 });
            Cars.Add(new Car() { Id = 23, Make = "BMW", Model = "735", Color = "Black", Km = 435, Price = 234512, Year = 1999 });
            Cars.Add(new Car() { Id = 234, Make = "Audi", Model = "Q3", Color = "Blue", Km = 345, Price = 334552, Year = 2010 });
            Cars.Add(new Car() { Id = 451, Make = "Volvo", Model = "V40", Color = "Grey", Km = 235235, Price = 535512, Year = 2008 });
            Cars.Add(new Car() { Id = 651, Make = "Volvo", Model = "XC90", Color = "White", Km = 345345, Price = 34510, Year = 2011 });
            Cars.Add(new Car() { Id = 91, Make = "Volvo", Model = "V70", Color = "Red", Km = 345, Price = 4512, Year = 1997 });
            Cars.Add(new Car() { Id = 8001, Make = "Audi", Model = "A3", Color = "White", Km = 123492, Price = 87500, Year = 2001 });
            Cars.Add(new Car() { Id = 631, Make = "Audi", Model = "A8", Color = "Blue", Km = 55342, Price = 55400, Year = 2010 });
            Cars.Add(new Car() { Id = 51, Make = "Volvo", Model = "V40", Color = "Red", Km = 1692, Price = 3465, Year = 1999 });
            Cars.Add(new Car() { Id = 781, Make = "Skoda", Model = "Fabia", Color = "Blue", Km = 1792, Price = 56556, Year = 2000 });
            Cars.Add(new Car() { Id = 144, Make = "Volvo", Model = "XC90", Color = "Blue", Km = 4382, Price = 25001, Year = 2004 });
            Cars.Add(new Car() { Id = 48, Make = "Volvo", Model = "V70", Color = "Red", Km = 12292, Price = 26512, Year = 1997 });
            Cars.Add(new Car() { Id = 912, Make = "BMW", Model = "735", Color = "Black", Km = 4395, Price = 134512, Year = 1960 });
            Cars.Add(new Car() { Id = 2344, Make = "Audi", Model = "Q3", Color = "Grey", Km = 3425, Price = 434552, Year = 2011 });
            Cars.Add(new Car() { Id = 4501, Make = "Volvo", Model = "V40", Color = "Grey", Km = 215235, Price = 435512, Year = 2007 });
            Cars.Add(new Car() { Id = 6051, Make = "Volvo", Model = "XC90", Color = "White", Km = 47345, Price = 134510, Year = 2012 });
            Cars.Add(new Car() { Id = 991, Make = "Volvo", Model = "V70", Color = "Red", Km = 3475, Price = 14512, Year = 1998 });
            Cars.Add(new Car() { Id = 801, Make = "Audi", Model = "A7", Color = "White", Km = 492, Price = 187500, Year = 2002 });
            Cars.Add(new Car() { Id = 6031, Make = "Audi", Model = "A6", Color = "Blue", Km = 553, Price = 55400, Year = 2011 });

        }


    }
}
