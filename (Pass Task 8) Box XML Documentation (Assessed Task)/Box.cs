using System;
using SplashKitSDK;
using NUnit.Framework;

namespace Task8
{
    /// <summary>
    /// This is the enumeration for the type of box material used.
    /// </summary>
    public enum Type
    {
        Cardboard,
        Plastic,
        Acrylic
    }

    /// <summary>
    /// This is the enumeration for the size of the box based on its dimensions.
    /// </summary>
    public enum Size
    {
        S,
        M,
        L,
        XL
    }

    public class Box
    {
        //Initialize Variables.
        private string _id;
        private Type _type;
        private double _widthInCM;
        private double _heightInCM;
        private double _lengthInCM;
        private Size _size;

        /// <summary>
        /// This is a pass-by-value constructor for the Box class. Fill the parameters when creating a new object.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="widthInCM"></param>
        /// <param name="heightInCM"></param>
        /// <param name="lengthInCM"></param>
        public Box(string id, Type type, double widthInCM, double heightInCM, double lengthInCM)
        {
            _id = id;
            _type = type;
            _widthInCM = widthInCM;
            _heightInCM = heightInCM;
            _lengthInCM = lengthInCM;
        }

        //Read-only Properties.
        /// <summary>
        /// This returns the width of the box in centimetres.
        /// </summary>
        /// <value></value>
        public double WidthInCM
        {
            get { return _widthInCM; }
        }

        /// <summary>
        /// This returns the height of the box in centimetres.
        /// </summary>
        /// <value></value>
        public double HeightInCM
        {
            get { return _heightInCM; }
        }

        /// <summary>
        /// This returns the length of the box in centimetres.
        /// </summary>
        /// <value></value>
        public double LengthInCM
        {
            get { return _lengthInCM; }
        }

        /// <summary>
        /// This returns the size of the box according to its dimensions.
        /// </summary>
        /// <value></value>
        public Size Size
        {
            get { return _size; }
        }

        /// <summary>
        /// This method calculates the dimensions in cubic centimetres of the box via its width, height and length and returns a double.
        /// </summary>
        /// <returns></returns>
        public double CalculateDimension()
        {
            return _widthInCM * _heightInCM * _lengthInCM;
        }
        
        /// <summary>
        /// This method calculates the weight in kilograms according to its dimension and returns a double.
        /// </summary>
        /// <returns></returns>
        public double CalculateDimensionWeightInKG()
        {
            return CalculateDimension() / 5000;
        }

        /// <summary>
        /// This method updates the size value of the box according to its dimensions.
        /// </summary>
        public void Update()
        {
            if (CalculateDimension()<=1000)
            {
                _size = Size.S;
            }
            else if(CalculateDimension()>1000  && CalculateDimension()<=3000)
            {
                _size = Size.M;
            }
            else if(CalculateDimension()>3000  && CalculateDimension()<=5000)
            {
                _size = Size.L;
            }
            else
            {
                _size = Size.XL;
            }
        }
        
        /// <summary>
        /// This method generates a string with the details of the box for PrintDetails() in Main to print to console.
        /// </summary>
        /// <returns></returns>
        public string GenerateDetails()
        {
            Update(); //To update the sizes of the box.
            return "Box ID: " + _id + "\nWidth: " + _widthInCM + "\nHeight: " + _heightInCM + "\nLength: " + _lengthInCM + "\nType: " + _type.ToString() + "\nBox Size: " + _size.ToString() + "\nBox Dimension: " + CalculateDimension();
        }

    }
}