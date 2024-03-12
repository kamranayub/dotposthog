using System.Collections.Generic;

namespace DotPostHog
{
  public static class DictionaryExtensions
  {
    public static IDictionary<TKey, TValue> Merge<TKey, TValue>(this IDictionary<TKey, TValue> first, IDictionary<TKey, TValue> second) where TValue : class
    {
      if (second == null || second.Count == 0) return first;

      foreach (var item in second)
      {
        if (typeof(IDictionary<TKey, TValue>).IsAssignableFrom(item.Value.GetType()))
        {
          if (first.ContainsKey(item.Key))
          {
            first[item.Key] = Merge(first[item.Key] as IDictionary<TKey, TValue>, item.Value as IDictionary<TKey, TValue>) as TValue;

          }
          else
          {
            first[item.Key] = item.Value;
          }
        }
        else
        {
          first[item.Key] = item.Value;
        }
      }

      return first;
    }
  }
}