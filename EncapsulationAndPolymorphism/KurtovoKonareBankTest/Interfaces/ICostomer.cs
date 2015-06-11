using System.Dynamic;

namespace KurtovoKonareBankTest.Interfaces
{
    interface ICostomer
    {
        string Name { get; }
        CostomerType CostomerType { get; }
    }
}
