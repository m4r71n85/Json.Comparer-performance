using JsonComparer.Core;
using JsonComparer.Core.Helpers;
using System.Diagnostics;

namespace CrazyApp
{
    class Program
    {
        const string JsonFileA = @"Resources\A.json";
        const string JsonFileB = @"Resources\B.json";
        const bool IsOutputFormatted = false;

        public static void Main(string[] args)
        {
            var comparer = new JsonCompare();
            var compareJsons = comparer.ParseJsonFiles(JsonFileA, JsonFileB);
            var intersectPks = comparer.IntersectPrimaryKeys(compareJsons);
            var changedValues = comparer.IntersectChangedValues(compareJsons);


            ConsoleHelpers.PrintObject(changedValues, IsOutputFormatted);
            ConsoleHelpers.PrintObject(intersectPks.JsonAPrimaryKeys, IsOutputFormatted);
            ConsoleHelpers.PrintObject(intersectPks.JsonBPrimaryKeys, IsOutputFormatted);
        }
    }

}