using System;

//Erin Rollestone - 10821741 - IFQ556 - Assignment Two

namespace AssignmentTwo
{
    //Original Automobile class from Assignment One
    public class Automobile
    {
        public string make;
        public int idNumber, year;
        public float price, discount;

        public Automobile(int idNumber, string make, int year, float price)
        {
            this.idNumber = idNumber;
            this.make = make;
            this.year = year;
            this.price = price;

            //year constraint
            if ((year < 1950) || (year > 2020))
            {
                Console.WriteLine("Error - Invalid Data - Year required to be between 1950 - 2020");
                Environment.Exit(1);
            }
        }

        //Add Constructor for discount but do not store as discount as a field
        public Automobile(int idNumber, string make, int year, float price, float discount)
        {
            this.idNumber = idNumber;
            this.make = make;
            this.year = year;
            this.price = price - (price * (discount / 100));

            //discount constraint
            if ((discount < 0) || (discount > 20))
            {
                Console.WriteLine("Error - Invalid Data - Discount required to be between 0% - 20%");
                Environment.Exit(1);
            }

            //year constraint
            if ((year < 1950) || (year > 2020))
            {
                Console.WriteLine("Error - Invalid Data - Year required to be between 1950 - 2020");
                Environment.Exit(1);
            }
        }

        //polymorphism override sting for discount automobile class
        public override string ToString()
        {
            return string.Format("idNumber: {0,-4} Make: {1,-10}   Year: {2,-5}   Price: {3,10}", this.idNumber, this.make, this.year, this.price.ToString("C2"));
        }
    }

    //extend automobile class with fincancedautomobile class
    public class FinancedAutomobile : Automobile
    {
        protected float finance;

        public FinancedAutomobile(int idNumber, string make, int year, int price, float finance) : base(idNumber, make, year, price)
        {
            this.finance = finance;

            //finance constraint
            if ((finance < 0) || (finance > 10))
            {
                Console.WriteLine("Error - Invalid Data - Finance required to be between 0% - 10%");
                Environment.Exit(1);
            }
        }

        //polymorphism override sting for financed automobile class
        public override string ToString()
        {
            return string.Format("idNumber: {0,-4} Make: {1,-10}   Year: {2,-5}   Price: {3,10}   Finance Rate: {4,-4}%", this.idNumber, this.make, this.year, this.price.ToString("C2"), this.finance.ToString("0.00"));
        }

        //Create class called TestAutombile
        public class TestAutomobile
        {
            //Main Method
            public static void Main(string[] args)
            {
                //Create 5 automobile objects
                Automobile automobile0 = new Automobile(1, "Toyota", 2013, 24000, 10);
                Automobile automobile1 = new Automobile(2, "Mitzibishi", 1998, 34000, 15);
                Automobile automobile2 = new Automobile(3, "Nissan", 2020, 44000, 9);
                Automobile automobile3 = new Automobile(4, "Porche", 2017, 74000, 5);
                Automobile automobile4 = new Automobile(5, "Mercedes", 2013, 34000, 20);
                //create 5 financed automobile objects
                Automobile automobile5 = new FinancedAutomobile(6, "Suzuki", 2013, 14000, 1);
                Automobile automobile6 = new FinancedAutomobile(7, "Rivian", 2020, 94000, 5);
                Automobile automobile7 = new FinancedAutomobile(8, "LandRover", 2010, 24000, 3);
                Automobile automobile8 = new FinancedAutomobile(9, "Lexus", 2015, 44000, 7);
                Automobile automobile9 = new FinancedAutomobile(10, "Mazda", 2009, 4000, 1);

                //Create array from all objects
                Automobile[] automobiles = new Automobile[10];
                automobiles[0] = automobile0;
                automobiles[1] = automobile1;
                automobiles[2] = automobile2;
                automobiles[3] = automobile3;
                automobiles[4] = automobile4;
                automobiles[5] = automobile5;
                automobiles[6] = automobile6;
                automobiles[7] = automobile7;
                automobiles[8] = automobile8;
                automobiles[9] = automobile9;

                //Create for loop to pass array and call toString ovveride
                foreach (Automobile a in automobiles)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}