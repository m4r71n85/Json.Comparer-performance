using JsonComparer.Models;
using System.Collections.Generic;

namespace JsonComparer
{
    public interface IJsonComparer
    {
        bool TryParseJsonFiles(string fileA, string fileB, out CompareJsonObjects compareObjects);

        /// <summary>
        /// Makes intersection between the two JsonObjects
        /// and creates object containing 2 properties:
        /// property JsonA will contain objects with Primary keys which exist in JsonA but not in JsonB
        /// property JsonB will contain objects with Primary keys which exist in JsonB but not in JsonA
        /// </summary>
        /// <param name="compareObjects">Object containing the two json objects to be compared</param>
        /// <returns>Two json objects containing filtered result</returns>
        CompareJsonObjects ExceptIntersect(CompareJsonObjects compareObjects);

        /// <summary>
        /// Makes intersection between the two JsonObjects
        /// and leaves only records with unique Primary Key object and different values
        /// </summary>
        /// <param name="compareObjects">Object containing the two json objects to be compared</param>
        /// <param name="shouldLeaveOnlyDifferentValues">Option that will leave only values that are diffent</param>
        Dictionary<PrimaryKeyDto, ValueDto> IntersectByPrimaryKey(CompareJsonObjects compareObjects, bool shouldLeaveOnlyChangedValues);

    }
}
