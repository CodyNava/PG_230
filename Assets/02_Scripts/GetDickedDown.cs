using UnityEngine;

public class GetDickedDown : MonoBehaviour
{
    public ChangeText randomizer;
    private void IGotDickedDown()
    {
        transform.position += Vector3.down;
        randomizer.UpdateText();
    }
}