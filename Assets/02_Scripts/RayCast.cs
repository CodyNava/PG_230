using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class RayCast : MonoBehaviour
{
    private int gotDickedAmount = 0;

    public ChangeText randomizer;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (gotDickedAmount == Random.Range(5, 11) || gotDickedAmount >= 11)
                {
                    gotDickedAmount = 0;
                    randomizer.UpdateText();
                }
                else
                {
                    gotDickedAmount++;
                    Debug.Log("you got dickes times: " + gotDickedAmount);
                }

                GameObject dickedObject = hit.transform.gameObject;
                dickedObject.SendMessage("IGotDickedDown", SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}