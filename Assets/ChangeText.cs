using TMPro;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private RandomQuoteGenerator quotes;
    [SerializeField] private TMP_Text text;

    public void UpdateText()
    {
        text.text = quotes.RandomQuote();
    }
}
