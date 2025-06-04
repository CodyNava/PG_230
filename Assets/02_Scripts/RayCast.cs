using System;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                GameObject dickedObject = hit.transform.gameObject;
                dickedObject.SendMessage("IGotDickedDown", SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}