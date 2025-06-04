using UnityEngine;

public class GetDickedDown : MonoBehaviour
{
    private int i = 0;
    public ChangeText randomizer;
    public AudioSource mineSound;

    private void IGotDickedDown()
    {
        transform.position += Vector3.down;
        if (mineSound.isPlaying == true)
        {
            mineSound.Stop();
        }

        if (mineSound.isPlaying == false)
        {
            mineSound.pitch = Random.Range(0.95f, 1.05f);
            mineSound.Play();
        }

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