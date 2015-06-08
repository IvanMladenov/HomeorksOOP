using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P6_BitArray
{
    class BitArray
    {
        public const int MaxSize = 100000;
        private StringBuilder array;
        private int lenght;

        public BitArray(int lenght)
        {
            this.Array = new StringBuilder(new string('0',lenght));        
        }

        public int Lenght 
        {
            get { return this.lenght; }
            set
            {
                if(value<1||value>MaxSize)
                {
                    throw new IndexOutOfRangeException("Bit array size must be between [1..100000]");
                    
                }
                this.lenght = value;
            }
        }

        public StringBuilder Array
        { 
            get { return this.array; }

            set 
            {

                this.array = value; 
            } 
        }

        public int this[int index]
        {
            get { return (array[array.Length-1-index]); }

            set
            {
                if(index<0||index>array.Length-1)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Index should be between[0...{0}]", array.Length - 1));
                }
                if(value<0||value>1)
                {
                    throw new ArgumentException("Invalid bit.");
                }
                
                array[array.Length-1-index] =(char)(value+48);
            }
        }

        public override string ToString()
        {
            BigInteger number = new BigInteger();

            for (int i = this.array.Length-1,counter=0; i >= 0; i--,counter++)
            {
                if(array[i]=='1')
                {
                    number += (BigInteger)(Math.Pow(2, counter));
                }
            }

            return number.ToString();
        }

    }
}
