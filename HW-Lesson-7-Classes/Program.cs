using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_7_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Q8

            Computer comp = new Computer();
            comp.model = "Intel";
            comp.price = 4500;
            comp.numberOfProcessors = 4;
            comp.screenSize = 24.3f;
            comp.TellMeThePrice();
            comp.TellMeTheScreenSize();
            comp.TurnOn();
            Console.WriteLine(comp);
            comp.AddProcessor();
            comp.TurnOff();
            Console.WriteLine(comp);

            #endregion

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            #region Q9

            Table t1 = new Table();
            t1.legs = 4;
            t1.color = "brown";
            t1.type = "Oak";

            Table t2 = new Table(3, "black", "wood");

            Table t3 = new Table()
            {
                legs = 6,
                type = "glass",
                color = "clear"

            };

            Table t4 = new Table();
            t4 = t2;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);

            t2.legs = 1;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);

            t4.color = "red";

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);

            #endregion

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            #region Q10

            Rectangle r = new Rectangle(4, 10);
            Console.WriteLine(r.area);
            Console.WriteLine(r.scope);

            #endregion

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            #region Class Exercise

            Plane[] p = new Plane[3];
            string compan = "";

            for (int i = 0; i < 3; i++)
            {
                int seats = (i + 1) * 10 + 50;

                switch (i)
                {
                    case 0:
                        compan = "El Al";
                        break;

                    case 1:
                        compan = "Arkia";
                        break;

                    case 2:
                        compan = "Airlines";
                        break;
                }
                p[i] = new Plane(seats, compan);
                Console.WriteLine(p[i].seats + " " + p[i].company);
                Console.WriteLine();
            }

            Plane p1 = new Plane()
            {
                seats = 56,
                company = "Emirates",
                pilot = "Ezra"
            };
            Console.WriteLine(p1.seats + " " + p1.company + " " + p1.pilot);

            #endregion

            Console.ReadLine();

        }
    }
    class Computer
    {
        public string model;
        public int price;
        public int numberOfProcessors;
        public float screenSize;
        public bool isTurnOn;

        public void TellMeThePrice()
        {
            Console.WriteLine("Price:" + price);
        }

        public void TellMeTheScreenSize()
        {
            Console.WriteLine("Screen Size: " + screenSize);
        }

        public void TurnOn()
        {
            isTurnOn = true;
        }
        public void TurnOff()
        {
            isTurnOn = false;
        }
        public void AddProcessor()
        {
            numberOfProcessors++;
        }
        public override string ToString()
        {
            string a;
            a = "Model: " + model + ". Price: " + price + ". Screen Size: " + screenSize + ". IsTurnON = " + isTurnOn;
            return a;
        }
    }

    class Table
    {
        public int legs;
        public string color;
        public string type;

        public Table()
        {

        }

        public Table(int legs, string color, string type)
        {
            this.legs = legs;
            this.color = color;
            this.type = type;
        }

        public override string ToString()
        {
            return "Legs: " + legs + ". Color = " + color + ". type: " + type;
        }
    }

    class Rectangle
    {
        public double area;
        public double scope;

        public Rectangle(int length, int width)
        {
            area = GetArea(length, width);
            scope = GetScope(length, width);
        }

        public double GetArea(int length, int width)
        {
            area = length * width;
            return area;
        }

        public double GetScope(int length, int width)
        {
            scope = length + length + width + width;
            return scope;
        }
    }

    class Plane
    {
        public int seats;
        public string pilot;
        public string company;

        public Plane()
        {

        }

        public Plane(int _seats, string _company)
        {
            seats = _seats;
            company = _company;
        }
    }
}
