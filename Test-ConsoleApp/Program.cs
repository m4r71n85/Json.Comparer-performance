using JsonComparer.Core;
using JsonComparer.Core.Helpers;
using System.Diagnostics;

namespace CrazyApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            var comparer = new JsonCompare();
            var compareJsons = comparer.ParseJsonFiles(@"Resources\A-big.json", @"Resources\B-big.json");
            var intersectPks = comparer.IntersectPrimaryKeys(compareJsons);
            var changedValues = comparer.IntersectChangedValues(compareJsons);


            ConsoleHelpers.PrintObject(intersectPks.JsonAPrimaryKeys);
            //ConsoleHelpers.PrintObject(intersectPks.JsonBPrimaryKeys);
            //ConsoleHelpers.PrintObject(changedValues);
        }
    }

}