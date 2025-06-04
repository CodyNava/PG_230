using TMPro;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private RandomQuoteGenerator quotes;
    [SerializeField] private TMP_Text text;
    private string lastText;

    public void UpdateText()
    {
        lastText = text.text;
        text.text = quotes.RandomQuote();
        if (lastText == text.text)
        {
            quotes.RandomQuote();
        }
    }
}