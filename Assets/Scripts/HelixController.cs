using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixController : MonoBehaviour
{

    private Vector2 lasTapPosition;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.localEulerAngles;    
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 currentTapPosition = Input.mousePosition;

            if(lasTapPosition==Vector2.zero)
            {
                lasTapPosition = currentTapPosition;
            }

            float distance = lasTapPosition.x - currentTapPosition.x;
            lasTapPosition = currentTapPosition;

            transform.Rotate(Vector3.up * distance);

            if (Input.GetMouseButtonUp(0))
            {
                lasTapPosition = Vector2.zero;
            }
        }
    }
}
