
namespace P_03_GenericList
{
    using System;

    class Program
    {
        static void Main()
        {
            GenericList<string> list = new GenericList<string>();

            list.Add("Ivan");
            list.Add("Gosho");
            list.Add("Pesho");
            list.InsertAt(1, "Maria");
            Console.WriteLine(list.IndexOf("Maria"));//Index is 1, we insert Maria at 1
            list.Remove(0);//Remove Ivan From list            
            Console.WriteLine(list.Value(2));//Pesho is at index 2 after removing Ivan
            Console.WriteLine(list);//Entire list
            Console.WriteLine(list.ContainValue());//Check if the list contains value - True
            list.Clear();//Clear all values
            Console.WriteLine(list.ContainValue());//Check if the clear is correct
            list.Add("A");//Add some border values to check Min Max functionality
            list.Add("Z");
            Console.WriteLine("Min: {0}, Max: {1}",list.Min(list),list.Max(list));//Check Min, Max

            System.Reflection.MemberInfo type = typeof(GenericList<>);
            foreach (object item in type.GetCustomAttributes(false))
            {
                Console.WriteLine(item);
            }
        }
    }
}
