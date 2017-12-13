using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamV2
{
    public class Passenger

    {

        private string Name;
        private double Weight;

        public Passenger(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;

        }

        public string GetName()
        {
            return Name;
        }

        public double GetWeight()
        {

            return Weight;
        }
    }

    public class Elevator

    {
        private double MaxWeight;
        private int MaxOccupants;
        private Passenger[] Occupants;
        private double totalWeight;

        public Elevator(int maxOccupants, double maxWeight)
        {
            this.MaxWeight = maxWeight;
            Occupants = new Passenger[maxOccupants];
            MaxOccupants = maxOccupants;
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            totalWeight = 0;

            for (int i = 0; i < MaxOccupants; i++)
            {
                totalWeight += Occupants[i].GetWeight();
            }
            return totalWeight;
        }

        public bool IsOverMaxCapacity()
        {
            if (totalWeight > MaxWeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }


    class Program
    {
        public static void Main(string[] args)
        {
            Elevator elevator1 = new Elevator(2, 400);

            Passenger A1 = new Passenger("A1", 180);

            Passenger A2 = new Passenger("A2", 220);

            elevator1.AddOccupant(A1, 0);

            elevator1.AddOccupant(A2, 1);

            bool elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();

            Elevator elevator2 = new Elevator(3, 600);

            Passenger B1 = new Passenger("A1", 200);

            Passenger B2 = new Passenger("A2", 200);

            Passenger B3 = new Passenger("A3", 201);



            elevator2.AddOccupant(B1, 0);

            elevator2.AddOccupant(B2, 1);

            elevator2.AddOccupant(B3, 2);


            bool elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();

        }
    }
}