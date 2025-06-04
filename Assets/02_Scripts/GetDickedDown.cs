using UnityEngine;

public class GetDickedDown : MonoBehaviour
{
    private int i = 0;
    public ChangeText randomizer;

    private void IGotDickedDown()
    {
        transform.position += Vector3.down;
        if (i == Random.Range(3, 6) || i > 5)
        {
            i = 0;
            randomizer.UpdateText();
            Debug.Log("Updated Text");
        }
        else
        {
            i++;
            Debug.Log("Count up: " + i);
        }
    }
}