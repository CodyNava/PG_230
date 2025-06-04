using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RandomQuoteGenerator", menuName = "Scriptable Objects/RandomQuoteGenerator")]
public class RandomQuoteGenerator : ScriptableObject
{
    public List<string> list;

    public string RandomQuote()
    {
        return list[Random.Range(0, list.Count)];
    }
}
