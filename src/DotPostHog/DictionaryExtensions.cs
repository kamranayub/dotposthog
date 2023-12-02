using System.Collections.Generic;

namespace DotPostHog
{
  public static class DictionaryExtensions
  {
    public static IDictionary<TKey, TValue> Merge<TKey, TValue>(this IDictionary<TKey, TValue> first, IDictionary<TKey, TValue> second)
    {
      if (second == null || second.Count == 0) return first;
      
      foreach (var item in second)
      {
        first[item.Key] = item.Value;
      }

      return first;
    }
  }
}