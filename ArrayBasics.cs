using System;

namespace CalculatorLib;

    public class ArrayBasics
    {
        private string[] _myArray;
        public string[] myArray
        {
            get { return _myArray; }
            set { _myArray = value; }
        }

        public ArrayBasics(int size)
        {
            _myArray = new string[size];
        }
        public ArrayBasics(string[] array)
        {
            _myArray = array;
        }

        public ArrayBasics()
        {
            _myArray = new string[10];
        }

        public override string ToString()
        {
          return "";
        }
        
        public void ToUpper()
        {
           return;
        }

    }
