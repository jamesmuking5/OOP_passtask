using System;
using SplashKitSDK;
using NUnit.Framework;
using System.Runtime.Intrinsics.X86;

namespace Task8
{
    /// <summary>
    /// This is a test class for methods in Box.cs.
    /// </summary>
    [TestFixture()]
    public class BoxTest
    {
        [Test()]
        /// <summary>
        /// This method tests CalculateDimension().
        /// </summary>
        public void TestCalculateDimension()
        {
            Box b1 = new Box("Testbox_1", Type.Acrylic, 50, 50, 50);

            double dimension = b1.CalculateDimension();

            Assert.AreEqual(dimension, (50 * 50 * 50));
        }
        [Test()]
        /// <summary>
        /// This method tests Update() to see if it updates the size accordingly with its dimensions.
        /// </summary>
        public void TestUpdate()
        {
            Box b2 = new Box("Testbox_2",Type.Cardboard, 30, 20, 5); //Should equal 3000 which is size M.

            b2.Update();

            Assert.AreEqual(Size.M, b2.Size);
        }
        [Test()]
        /// <summary>
        /// This method tests GenerateDetails() to see if it properly generates the string as designed.
        /// </summary>
        public void TestGenerateDetails()
        {
            Box b3 = new Box("Testbox_3", Type.Plastic, 50, 50, 50);

            string detailsgen = b3.GenerateDetails();
            string detailscheck = "Box ID: Testbox_3\nWidth: 50\nHeight: 50\nLength: 50\nType: Plastic\nBox Size: XL\nBox Dimension: 125000";

            Assert.AreEqual(detailsgen,detailscheck);
        }
    }
}