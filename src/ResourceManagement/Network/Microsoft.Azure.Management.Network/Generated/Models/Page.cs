// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Defines a page in Azure responses.
    /// </summary>
    /// <typeparam name="T">Type of the page content items</typeparam>
    [JsonObject]
    public class Page<T> : IPage<T>
    {
         /// <summary>
         /// Gets the link to the next page.
         /// </summary>
         [JsonProperty("nextLink")]
         public string NextPageLink { get; private set; }

         [JsonProperty("value")]
         private IList<T> Items{ get; set; }

         /// <summary>
         /// Returns an enumerator that iterates through the collection.
         /// </summary>
         /// <returns>A an enumerator that can be used to iterate through the collection.</returns>
         public IEnumerator<T> GetEnumerator()
         {
              return (Items == null) ? Enumerable.Empty<T>().GetEnumerator() : Items.GetEnumerator();
         }

         /// <summary>
         /// Returns an enumerator that iterates through the collection.
         /// </summary>
         /// <returns>A an enumerator that can be used to iterate through the collection.</returns>
         System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
         {
             return GetEnumerator();
         }
    }
}
