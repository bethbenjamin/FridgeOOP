using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    public class Fridge //remember to add public
    {
        // add these 4 items at the beginning of all classes (1. fields, 2. Properties 3. Constructors 4. Methods)
        //fields (camelCase)
        private bool isClean;
        private string dispenserType;
        private int foodAmount;
        private bool bulbsWork;

        //Properties (PascalCase)

        //GET property accessor is used to return the property value.
        //SET property accessor is used to assign a new value. 

        public bool IsClean // adding PascalCase makes this declares a STATE
        {
            get { return this.isClean; }
            set { this.isClean = value; }
        }

        public string DispenserType
        {
            get { return this.dispenserType; }
            set { this.dispenserType = value; }

        }
        public int FoodAmount
        {
            get { return this.foodAmount; }
            set { this.foodAmount = value; }

        }
        public bool BulbsWork
        {
            get { return this.bulbsWork; }
            set { this.bulbsWork = value; }
        }


        //Behaviors
        //Constructors

        public Fridge()
        {
            this.dispenserType = " basic water dispenser"; // we are setting constructor blueprints for Objects (Fridge) 
        }

        public Fridge(string dispenserType)
        {
            this.dispenserType = dispenserType;
        }

        public Fridge(bool isClean, string dispenserType, int foodAmount, bool bulbsWork)
        {
            this.isClean = isClean;
            this.dispenserType = dispenserType;
            this.foodAmount = foodAmount;
            this.bulbsWork = bulbsWork;
        }


        //Methods()
        //I need a way to dispense water
        public void DispenseWater() // you could do a switch on this too!
        {
            if (dispenserType == "basic water dispenser")
            {
                Console.WriteLine("here's some lukewarm water!");
            }
            else if (dispenserType == "deluxe dispenser")
            {
                Console.WriteLine("enjoy your perfect ice water");
            }

            else
            {
                Console.WriteLine("what's gonna come out? It's a surprise!");
            }


        }

        public string ChangeBulbs()
        {
            if (bulbsWork == false)
            {
                bulbsWork = true;
                return "The bulbs have been changed.";
            }
            else
            {
                return "the bulbs dont have to be changed";

            }
        }
        public void RemoveFood (int foodRemoved)
        {
            foodAmount -= foodRemoved;
        }

        public string CheckSupplies()
        {
            if (foodAmount >= 80)
            {
                return "fully stocked";
            }
            else if (foodAmount > 40)
            {
                return "getting low"
;
            }
            else
            {
                return "time to grocery shop";
            }

        }

        public string Clean(bool isDirty)
            {
                if (isDirty)
                {
                    isClean = false;
                    return "I cleaned the fridge";
                }
                else
                {
                    return "the fridge is already clean.";
                }

            }
    }
}
