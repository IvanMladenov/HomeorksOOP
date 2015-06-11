using System;
using KurtovoKonareBankTest.Interfaces;

namespace KurtovoKonareBankTest.Classes
{
     class Costomer:ICostomer
     {
         private string name;

         public Costomer(string name,CostomerType costomerType)
         {
             this.Name = name;
             this.CostomerType = costomerType;
         }

         public string Name
         {
             get { return this.name; }

             private set
             {
                 if (string.IsNullOrEmpty((value)))
                 {
                     throw new ArgumentNullException("Name cant be null or emtpy!");
                 }
                 this.name = value;
             }
         }


         public CostomerType CostomerType { get; private set; }

         public override string ToString()
         {
             return string.Format("{0} - {1}", this.Name, this.CostomerType);
         }
     }
}
