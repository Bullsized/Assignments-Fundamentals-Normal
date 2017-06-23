using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Jarvis
{
    class Program
    {
        static void Main(string[] args)
        {
            long jarvisHealth = long.Parse(Console.ReadLine());

            bool passTheFirstArm = false;
            bool passTheFirstLeg = false;

            var armOne = new Arms()
            {
                EnergyCons = int.MaxValue,
                Reach = 0,
                Fingers = 0
            };

            var armTwo = new Arms()
            {
                EnergyCons = int.MaxValue,
                Reach = 0,
                Fingers = 0
            };

            var legOne = new Legs()
            {
                EnergyCons = int.MaxValue,
                Strength = 0,
                Speed = 0
            };

            var legTwo = new Legs()
            {
                EnergyCons = int.MaxValue,
                Strength = 0,
                Speed = 0
            };

            var torsoClass = new Torso()
            {
                EnergyCons = int.MaxValue,
                Processor = 0.0,
                Material = string.Empty
            };
            var headClass = new Head()
            {
                EnergyCons = int.MaxValue,
                IQ = 0,
                Material = string.Empty
            };

            string inputLine = Console.ReadLine();

            while (inputLine != "Assemble!")
            {
                string[] inputLineToArray = inputLine.Split();
                int givenConsumptionOfEnergy = int.Parse(inputLineToArray[1]);

                if (inputLineToArray[0] == "Head")
                {
                    if (headClass.EnergyCons >= givenConsumptionOfEnergy)
                    {
                        headClass.EnergyCons = givenConsumptionOfEnergy;
                        headClass.IQ = int.Parse(inputLineToArray[2]);
                        headClass.Material = inputLineToArray[3];
                    }

                }

                if (inputLineToArray[0] == "Torso")
                {
                    if (torsoClass.EnergyCons >= givenConsumptionOfEnergy)
                    {
                        torsoClass.EnergyCons = givenConsumptionOfEnergy;
                        torsoClass.Processor = double.Parse(inputLineToArray[2]);
                        torsoClass.Material = inputLineToArray[3];
                    }

                }

                if (inputLineToArray[0] == "Arm")
                {
                    if (passTheFirstArm == false && armOne.EnergyCons >= givenConsumptionOfEnergy)
                    {
                        armOne.EnergyCons = givenConsumptionOfEnergy;
                        armOne.Reach = int.Parse(inputLineToArray[2]);
                        armOne.Fingers = int.Parse(inputLineToArray[3]);
                        passTheFirstArm = true;
                    }
                    else if (armTwo.EnergyCons >= givenConsumptionOfEnergy)
                    {
                        armTwo.EnergyCons = givenConsumptionOfEnergy;
                        armTwo.Reach = int.Parse(inputLineToArray[2]);
                        armTwo.Fingers = int.Parse(inputLineToArray[3]);
                        passTheFirstArm = false;
                    }
                }

                if (inputLineToArray[0] == "Leg")
                {
                    if (passTheFirstLeg == false && legOne.EnergyCons >= givenConsumptionOfEnergy)
                    {
                        legOne.EnergyCons = givenConsumptionOfEnergy;
                        legOne.Strength = int.Parse(inputLineToArray[2]);
                        legOne.Speed = int.Parse(inputLineToArray[3]);
                        passTheFirstLeg = true;
                    }
                    else if (legTwo.EnergyCons >= givenConsumptionOfEnergy)
                    {
                        legTwo.EnergyCons = givenConsumptionOfEnergy;
                        legTwo.Strength = int.Parse(inputLineToArray[2]);
                        legTwo.Speed = int.Parse(inputLineToArray[3]);
                        passTheFirstLeg = false;
                    }
                }

                inputLine = Console.ReadLine();
            }

            long sumOfAllComponentsEnergy = armOne.EnergyCons + armTwo.EnergyCons +
                legOne.EnergyCons + legTwo.EnergyCons + headClass.EnergyCons +
                torsoClass.EnergyCons;

            //print method VVV
            if (jarvisHealth < sumOfAllComponentsEnergy)
            {
                Console.WriteLine("We need more power!");
            }
            else if (armOne.EnergyCons == int.MaxValue || armTwo.EnergyCons == int.MaxValue ||
     legOne.EnergyCons == int.MaxValue || legTwo.EnergyCons == int.MaxValue ||
     headClass.EnergyCons == int.MaxValue || torsoClass.EnergyCons == int.MaxValue)
            {
                Console.WriteLine("We need more parts!");
            }
            else
            {
                Console.WriteLine("Jarvis:");
                Console.WriteLine("#Head:");
                Console.WriteLine("###Energy consumption: {0}", headClass.EnergyCons);
                Console.WriteLine("###IQ: {0}", headClass.IQ);
                Console.WriteLine("###Skin material: {0}", headClass.Material);
                Console.WriteLine("#Torso:");
                Console.WriteLine("###Energy consumption: {0}", torsoClass.EnergyCons);
                Console.WriteLine("###Processor size: {0}", torsoClass.Processor);
                Console.WriteLine("###Corpus material: {0}", torsoClass.Processor);
                Console.WriteLine("#Arm:");
                Console.WriteLine("###Energy consumption: {0}", armOne.EnergyCons);
                Console.WriteLine("###Reach: {0}", armOne.Reach);
                Console.WriteLine("###Fingers: {0}", armOne.Fingers);
                Console.WriteLine("#Arm:");
                Console.WriteLine("###Energy consumption: {0}", armTwo.EnergyCons);
                Console.WriteLine("###Reach: {0}", armTwo.Reach);
                Console.WriteLine("###Fingers: {0}", armTwo.Fingers);
                Console.WriteLine("#Leg:");
                Console.WriteLine("###Energy consumption: {0}", legOne.EnergyCons);
                Console.WriteLine("###Strength: {0}", legOne.Strength);
                Console.WriteLine("###Speed: {0}", legOne.Speed);
                Console.WriteLine("#Leg:");
                Console.WriteLine("###Energy consumption: {0}", legTwo.EnergyCons);
                Console.WriteLine("###Strength: {0}", legTwo.Strength);
                Console.WriteLine("###Speed: {0}", legTwo.Speed);
            }
        }
    }

    class Arms
    {
        public int EnergyCons { get; set; }
        public int Reach { get; set; }
        public int Fingers { get; set; }
    }
    class Legs
    {
        public int EnergyCons { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
    }
    class Torso
    {
        public int EnergyCons { get; set; }
        public double Processor { get; set; }
        public string Material { get; set; }
    }
    class Head
    {
        public int EnergyCons { get; set; }
        public int IQ { get; set; }
        public string Material { get; set; }
    }
}