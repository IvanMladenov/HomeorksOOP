
namespace P_03_GenericList
{
    using System;
    using System.Text;

    [Version(1,1)]
    class GenericList <T>
    {
        public const int DefaultLenght=16;

        private T[] array;

        private int currentIndex = 0;

        public GenericList(int lenght=DefaultLenght)
        {
            this.array=new T[lenght];
        }

        private int CurrentIndex
        {
            get
            {
                return this.currentIndex;
            }
        }

        public T Value(int index)
        {
            if (index >= this.currentIndex)
            {
                throw new IndexOutOfRangeException("No value on this index.");
            }
            else if(index<0)
            {
                throw new IndexOutOfRangeException("Index must be greather or equal to 0.");
            }
            T value = this.array[index];
            return value;
        }

        public void Add(T element)
        {
            if (this.currentIndex == this.array.Length)
            {
                this.Resize();
            }

            this.array[this.currentIndex] = element;
            this.currentIndex++;
        }

        public void Remove(int index)
        {
            if (index >= this.currentIndex)
            {
                throw new IndexOutOfRangeException("No value on this index.");
            }
            else if (index < 0)
            {
                throw new IndexOutOfRangeException("Index must be greather or equal to 0.");
            }
            else if(index>this.CurrentIndex)
            {
                throw new IndexOutOfRangeException("No value to remove at this index.");
            }

            for (int i = index; i < this.CurrentIndex; i++)
            {
                this.array[i] = this.array[i + 1];
            }
            this.currentIndex--;
        }

        public void InsertAt(int index,T element)
        {
            if (index > this.currentIndex)
            {
                throw new IndexOutOfRangeException("Index is bigger than array Lenght");
            }
            else if(index<0)
            {
                throw new IndexOutOfRangeException("Index must be greather or equal to 0.");
            }
            if (this.currentIndex == this.array.Length)
            {
                this.Resize();
            }
            T currentValue=this.array[index];
            this.array[index] = element;
            for (int i = index+1; i < this.currentIndex+1; i++)
            {
                T member=this.array[i];
                this.array[i] = currentValue;
                currentValue = member;
            }
            this.currentIndex++;
        }

        private void Resize()
        {
            int newSize = this.array.Length * 2;
            T[] newArray=new T[newSize];

            for (int i = 0; i < this.currentIndex; i++)
            {
                newArray[i] = this.array[i];
            }
            this.array = newArray;
        }

        public  T Min<T>(GenericList<T> list)
           where T : IComparable
        {
            T min = list[0];
            for (int index = 1; index < list.CurrentIndex; index++)
            {
                if (min.CompareTo(list[index]) == 1)
                {
                    min = list[index];
                }
            }

            return min;
        }

        public  T Max<T>(GenericList<T> list) where T : IComparable
        {
            T max = list[0];
            for (int index = 1; index < list.CurrentIndex; index++)
            {
                if (list[index].CompareTo(max) == 1)
                {
                    max = list[index];
                }              
            }
            return max;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || this.array.Length <= index)
                {
                    throw new IndexOutOfRangeException("Index is outside the boundaries of the GenericList.");
                }

                return this.array[index];
            }
        }

        public void Clear()
        {
            for (int i = 0; i < this.CurrentIndex; i++)
            {
                this.array[i] = default(T);
            }
            this.currentIndex = 0;
        }

        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            for (int i = 0; i < this.currentIndex; i++)
            {
                sb.Append(this.array[i]+", ");
            }
            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }

        public bool ContainValue()
        {
            if (this.currentIndex > 0)
            {
                return true;
            }
            return false;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (this.array[i].Equals(element))
                {
                    return i;
                }

            }
            return -1;
        }

       
    }
}
