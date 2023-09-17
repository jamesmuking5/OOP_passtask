using System;
using SplashKitSDK;
using NUnit.Framework;

namespace Task8
{
    public class Program
    {
        /// <summary>
        /// Method to print details of the boxes by calling GenerateDetails() from Box Class
        /// </summary>
        /// <param name="Boxes"></param> <summary>
        /// 
        /// </summary>
        /// <param name="Boxes"></param>
        public static void PrintDetails(Box[] Boxes)
        {
            foreach (Box b in Boxes)
            {
                Console.WriteLine("\n"+b.GenerateDetails());
            }
        }
        /// <summary>
        /// This is the main method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Initialising boxes.
            Box[] Boxes = new Box[3];
            Boxes[0] = new Box("B001", Type.Cardboard, 10, 20, 2);
            Boxes[1] = new Box("B002", Type.Plastic, 30, 20, 5);
            Boxes[2] = new Box("B003", Type.Acrylic, 300, 20, 3);
            
            //Printing the boxes' details.
            PrintDetails(Boxes);
        }
    }
}