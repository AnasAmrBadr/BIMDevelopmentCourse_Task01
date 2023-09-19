using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lecture_2_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Level #01
            // By: AB

            #region 1. Variables

            // 1. Variables
            // 1. As a structural engineer, you're working on a high-rise building.
            // Create a variable to represent the number of floors
            // ask the user to give you the value of the variable.
            // Print the variable's value.
            // Note: Initialize means to give it a value when define the variable.

            int numberOfFloors;

            Console.WriteLine("Please insert the number of floors below:");

            numberOfFloors = Convert.ToInt32(Console.ReadLine());

            if (numberOfFloors > 0 && numberOfFloors < 1000)
            {
                Console.WriteLine("The Building consists of " + numberOfFloors + " floors.");
            }
            else
            {
                Console.WriteLine("INPUT ERROR! Please insert logical number.");
            }

            Console.ReadLine();

            Console.WriteLine("..............................................................................");

            // 2.In an architectural project, you need to keep track of the dimensions of different rooms.
            // Create variables to store the length, width, and height of a room.
            // ask the user to give you the value of the variable.
            // Print the variable's value.   

            double roomLenght;
            double roomWidth;
            double roomHeight;

            Console.WriteLine("Please insert the room lenght in meters below:");
            roomLenght = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please insert the room width in meters below:");
            roomWidth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please insert the room height in meters below:");
            roomHeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The room Length is " + roomLenght + "m, the width is " + roomWidth + "m, and the height is " + roomHeight + "m.");
            Console.WriteLine("the room Area is " + roomLenght * roomWidth + "m^2.");
            Console.WriteLine("the room Volum is " + roomLenght * roomWidth * roomHeight + "m^3.");

            Console.ReadLine();

            Console.WriteLine("..............................................................................");

            // 3.As an MEP engineer, you're managing the energy consumption of a building.
            // Create variables to two HVAC systems.
            // Print the current HVAC systems names.
            // Now switch between the two HVAC systems by swapping their names stored in the variables.
            // Print the new HVAC systems names.

            string firstHVACSystem;
            string secondHVACSystem;

            firstHVACSystem = "Split System";
            secondHVACSystem = "Hybrid System";

            Console.WriteLine("The current HVAC Systems are {0} {1}.", firstHVACSystem, secondHVACSystem);

            firstHVACSystem = "Hybrid System";
            secondHVACSystem = "Split System";

            Console.WriteLine("The new HVAC Systems are {0} {1}.", firstHVACSystem, secondHVACSystem);


            Console.ReadLine();

            Console.WriteLine("..............................................................................");

            #endregion


            #region 2. Data Types

            // 2. Data Types
            // 1.In a structural analysis, you need to calculate the total weight of steel beams.
            // Prompt the user to input the length and weight per meter of each beam segment as doubles,
            // multiply them together.
            // display the total weight.

            double steelBeamLenght;
            double steelBeamWeight;

            Console.WriteLine("Please insert the beam length below in meters:");

            steelBeamLenght = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please insert the beam weight below per meter:");

            steelBeamWeight = Convert.ToDouble(Console.ReadLine());

            double steelBeamTotalWeight = steelBeamWeight * steelBeamLenght;

            Console.WriteLine("The total weigth of the beam is:" + steelBeamTotalWeight + ".");

            Console.WriteLine(".......................................................................................................");
            Console.ReadLine();



            // 2.You're working on an architectural project and need to indicate if a room is accessible to disabled individuals.
            // Create a Boolean variable to represent this.
            // print its value.

            bool theRoomDisabledSutability = false;

            Console.WriteLine("The room disabled accessibility condition is " + theRoomDisabledSutability + ".");


            Console.WriteLine(".......................................................................................................");
            Console.ReadLine();

            // 3.In an MEP project, you assign unique codes to electrical panels.
            // Create a character variable to represent a panel code.
            // print it.

            char panelCode = 'Z';

            Console.WriteLine("The Panel Code is " + panelCode + ".");

            Console.WriteLine(".......................................................................................................");
            Console.ReadLine();


            #endregion


            #region 3. Operators

            //3. Operators
            // 1.As an architect, you're estimating the cost of materials for a project.
            // Input the cost per unit area for flooring and the total area to be covered,
            // then multiply to calculate.
            // display the total cost.

            double costPerUnitArea = 5.5;
            double totalArea = 20.36;

            double totalCost = totalArea * costPerUnitArea;
            Console.WriteLine("The total cost is " + totalCost + ".");

            Console.WriteLine("......................................................................");
            Console.ReadLine();

            // 2.In a structural assessment, you need to determine the column’s capacity load using the following formula:
            // Pu = 0.35 * Ac * fcu + 0.67 * As * fy
            // Where:
            // Fcu = 25 MPA
            ////Fcu = 360 MPA
            //Ac = Column Width* Column Depth(take them from user )
            //As = 0.01 * Ac
            // Define the Variables: Pu, Ac, As, fcu, fy, columnWidth, columnDepth
            // Ask the user to give you the inputs value(Column width and Depth)
            // Use them in the formula to calculate the Pu.
            // Print Result

            int columnFcu = 25;
            int steelFy = 360;

            Console.WriteLine("Please insert the column width below in millimeters:");
            double columnWidth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please insert the column depth below in millimeters:");
            double columnDepth = Convert.ToDouble(Console.ReadLine());

            double columnAreaOfConcrete = columnWidth * columnDepth;

            double columnAreaOfSteel = 0.01 * columnAreaOfConcrete;

            double columnCompressiveCapacity = 0.35 * columnAreaOfConcrete * columnFcu + 0.67 * columnAreaOfSteel * steelFy;

            Console.WriteLine("The column compressive capacity is " + columnCompressiveCapacity + "N = " + columnCompressiveCapacity / 1000 + "kN.");

            Console.WriteLine("......................................................................");
            Console.ReadLine();

            // 3.You are an MEP engineer tasked with designing an electrical circuit for a room. The circuit includes a set of three light bulbs, and you need to calculate the total power consumption for these bulbs.
            // Each light bulb consumes 60 watts of power.Calculate the total power consumption of all three light bulbs in the circuit using the multiplication operator.
            // Formula:
            // Total Power Consumption = Number of Light Bulbs × Power Consumption per Bul

            int numberOfBulbs = 3;
            int bulbConsumption = 60;

            int totalPowerConsumption = numberOfBulbs * bulbConsumption;

            Console.WriteLine("The total power consumption is " + totalPowerConsumption + "watts.");

            Console.WriteLine("......................................................................");
            Console.ReadLine();

            #endregion


        }

    }
}
