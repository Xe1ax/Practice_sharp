using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class A
    {
        #region Private Fields
        private int _numA;
        private int _numB;
        #endregion

        #region Public fields
        public int NumA
        {
            get { return _numA; }
            set { _numA = value; }
        }
        public int NumbB
        {
            get { return _numB; }
            set { _numB = value; }
        }
        #endregion

        #region Constructor
        public A(int numA, int numB)
        {
            _numA = numA;
            _numB = numB;
        }
        #endregion

        #region Methods
        public int CalculateMultiplication(int NumA, int NumB)
        {
            return NumA * NumB;
        }
        public double CalculateValue(int NumA, int NumB)
        {
            return (Math.Sqrt(NumB)/ 2 * NumA);
        }
        public void Print(int NumA, int NumB)
        {
            Console.WriteLine($"Умножение числел {NumA} и {NumB} = {CalculateMultiplication(NumA,NumB)}"); 
            Console.WriteLine($"Решение выражения = {CalculateValue(NumA,NumB)}");
        }
        #endregion
    }
}