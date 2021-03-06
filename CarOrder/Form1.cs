using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarOrder
{
    public partial class Form1 : Form
    {
        List<Car> Cars;
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Amount of red cars";
            button2.Text = "Cars older than 2003";
            button3.Text = "Amount of grey Volovs";
            button4.Text = "Average miles on the BMW";
            button5.Text = "The most expensive car";
            Cars = new List<Car>();

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


            //Shows a list of cars in alphabetic order
            List<Car> Aplha = Cars.OrderBy(Alpha => Alpha.Make).ToList();

            foreach (var Car in Cars)
            {
                listBox1.Items.Add($"{Car.Make} {Car.Model} {Car.Year}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Shows a list of all red cars
            List<Car> Color = Cars.FindAll(x => x.Color == "Red").ToList();

            listBox2.Items.Add($"There are {Color.Count} red cars in stock");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Shows a list of all cars older than 2003
            List<Car> Age = Cars.FindAll(x => x.Year < 2003).ToList();
            listBox2.Items.Add($"There are {Age.Count} cars that are older than 2003");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Counts all the grey volvos
            List<Car> GVolvo = Cars.FindAll(x => x.Make == "Volvo").FindAll(y => y.Color == "Grey");

            listBox2.Items.Add($"There are {GVolvo.Count} grey volvos in stock");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Average Km on the BMW
            double MBMW = Cars.FindAll(x => x.Make == "BMW").Average(y => y.Km);

            listBox2.Items.Add($"The average km on the make BMW is {MBMW}km");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Finds the most expenive car
            List<Car> Mexpensive = Cars.OrderByDescending(x => x.Price).ToList();

           // ListBox2.Items.Add($"The most expenise car is {Make[0]}");
            
        }
    }
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Km { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
    }
}
