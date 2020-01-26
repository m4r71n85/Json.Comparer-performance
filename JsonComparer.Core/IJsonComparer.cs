using JsonComparer.Models;
using System.Collections.Generic;

namespace JsonComparer.Core
{
    public interface IJsonCompare
    {
        /// <summary>
        /// Parse two json text files into object with two properties
        /// for each Json object
        /// </summary>
        /// <param name="fileA">path to first json text file</param>
        /// <param name="fileB">path to secont json text file</param>
        /// <returns>Object with two parsed json objects as properties</returns>
        CompareJsonObjects ParseJsonFiles(string fileA, string fileB);

        /// <summary>
        /// Makes intersection between two JsonObjects
        /// and creates object containing 2 properties:
        /// property JsonA will contain objects with Primary keys which exist in JsonA but not in JsonB
        /// property JsonB will contain objects with Primary keys which exist in JsonB but not in JsonA
        /// </summary>
        /// <param name="compareObjects">Object containing two json objects to be compared</param>
        /// <returns>Two list of PrimaryKey objects containing filtered result</returns>
        ComparePrimaryKeysObjects IntersectPrimaryKeys(CompareJsonObjects compareObjects);

        /// <summary>
        /// Makes intersection between two JsonObjects
        /// and leaves only records with unique Primary Key object and different values
        /// </summary>
        /// <param name="jsonA">One of the json objects to be compared</param>
        /// <param name="jsonB">The other json objects to be compared</param>
        Dictionary<PrimaryKeyDto, ValueDto> IntersectChangedValues(CompareJsonObjects compareObjects);

    }
}
