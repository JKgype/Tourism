using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tourism
{
    public abstract class Ticket
    {
        private string name;
        private double flightday;
        public Ticket(string type, double flight_day)
        {
            this.name = type;
            flight_day = flightday;
        }
       

        /*public string Type
        {
            get { return name; }
            set { name = value; }
        }
        public double fligh_day
        {
            get
            {
                return flightday;
            }
            set
            {
                if (value > 0)
                {
                    flightday = value;
                }
                else throw new ArgumentException("The day of flight must be positive.");
            }
        }*/

        abstract public double Price();
        
    }
    public class AviaTickets : Ticket
    {
        AviaandApartmentType type;
        double price=100;
        private int select_aviaticket_type;
        public int numbertype
        {
            get
            {
                return select_aviaticket_type;
            }
            set
            {
                if ((value > 0)&&(value<5))
                {
                    select_aviaticket_type = value;
                }
                else throw new ArgumentException("You should press one number from 1 to 4.");
            }
        }

        public AviaTickets(string name, AviaandApartmentType type, int flight_day) :base(name,flight_day)
        {
            name = "Avia ticket";

            switch (numbertype)
            {
                case 1:type=AviaandApartmentType.Economy; break;
                case 2:type=AviaandApartmentType.PremiumEconomy; break;
                case 3:type=AviaandApartmentType.Business; break;
                case 4:type = AviaandApartmentType.FirstClass; break;
            }
        }
        public override double Price()
        {
            double amount=1;
            if (type == AviaandApartmentType.Economy) amount = 1;
            else if (type == AviaandApartmentType.PremiumEconomy) amount = 1.5;
            else if (type == AviaandApartmentType.Business) amount = 3;
            else if (type == AviaandApartmentType.FirstClass) amount = 5;
            return Math.Round(amount * price, 2);
        }

    }
    public class BusTickets : Ticket
    {
        int current_day=18;
        private int ride_day;
        public int rideday
        {  // читає
            get
            {
                return ride_day;
            }
            //задає значення
            set
            {
                if ((value > 0)&&(value<31))
                {
                    ride_day = value;
                }
                else throw new ArgumentException("Ride day must be from 1 till 31.");
            }
        }

        public BusTickets(string name, AviaandApartmentType type, int ride_day) : base(name, ride_day)
        {
            name = "Bus ticket";
            ride_day = rideday;
            
        }
        public override double Price()
        {
            return current_day*(ride_day-current_day);
        }

    }
}
