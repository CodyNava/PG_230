using UnityEngine;

public class GetDickedDown : MonoBehaviour
{
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
    }
}