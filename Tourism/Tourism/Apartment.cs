using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourism
{
    public abstract class Apartment
    {
        private string name;
        private double bookday;
        public Apartment(string type, double book_day)
        {
            this.name = type;
            book_day = bookday;
        }
        abstract public double Price();
    }
    public class Hotel : Apartment
    {
        AviaandApartmentType type;
        double price = 135.45;
        private int select_hotel_type;
        private int days;
        public int numbertype
        {
            get
            {
                return select_hotel_type;
            }
            set
            {
                if ((value > 0) && (value < 5))
                {
                    select_hotel_type = value;
                }
                else throw new ArgumentException("You should press one number from 1 to 4.");
            }
        }
        public int days_in_hotel
        {
            get
            {
                return days;
            }
            set
            {
                if ((value > 0) && (value < 100))
                {
                    days = value;
                }
                else throw new ArgumentException("You should input more than 1 day.");
            }
        }
        public Hotel(string name, AviaandApartmentType type, int book_day) : base(name, book_day)
        {
            name = "Hotel";

            switch (numbertype)
            {
                case 1: type = AviaandApartmentType.Economy; break;
                case 2: type = AviaandApartmentType.PremiumEconomy; break;
                case 3: type = AviaandApartmentType.Business; break;
                case 4: type = AviaandApartmentType.FirstClass; break;
            }
        }
        public override double Price()
        {
            double amount = 1;
            if (type == AviaandApartmentType.Economy) amount = 1;
            else if (type == AviaandApartmentType.PremiumEconomy) amount = 1.5;
            else if (type == AviaandApartmentType.Business) amount = 3;
            else if (type == AviaandApartmentType.FirstClass) amount = 5;
            return Math.Round(amount * price*days, 2);
        }
    }

    public class Villa : Apartment
    {
        double price = 1000;
        private double area;
        private int days;
        public double numbertype
        {
            get
            {
                return area;
            }
            set
            {
                if ((value > 100) && (value < 500000))
                {
                    area = value;
                }
                else throw new ArgumentException("You should input area from 100 till 500 000 m kv");
            }
        }
        public int days_in_villa
        {
            get
            {
                return days;
            }
            set
            {
                if ((value > 0) && (value < 100))
                {
                    days = value;
                }
                else throw new ArgumentException("You should input more than 1 day.");
            }
        }
        public Villa(string name, int book_day) : base(name, book_day)
        {
            name = "Villa";

           
        }
        public override double Price()
        {
            double amount = 1;
            if (area<500) amount = 1.5;
            else if (area>500&&area<100000) amount = 3;
            else if (area>100000) amount = 5;
            return Math.Round(amount * price * days, 2);
        }
    }
    public class Motel : Apartment
    {
        double price = 50;
        private int days;
        public int days_in_motel
        {
            get
            {
                return days;
            }
            set
            {
                if ((value > 0) && (value < 100))
                {
                    days = value;
                }
                else throw new ArgumentException("You should input more than 1 day.");
            }
        }
        public Motel(string name, int book_day) : base(name, book_day)
        {
            name = "Villa";
        }
        public override double Price()
        {
            return Math.Round(price * days, 2);
        }
    }
}
