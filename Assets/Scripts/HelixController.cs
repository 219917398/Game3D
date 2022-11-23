using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixController : MonoBehaviour
{

    private Vector2 lasTapPosition;
    private Vector3 startPosition;

    public Transform topTransform;
    public Transform goalTransform;
    
    public GameObject helixLevelPrefab;

    public List<Stage> allStages = new List<Stage>();

    public float helixDistance;

    private List<GameObject> spawnedLevels = new List<GameObject>();

    private void Awake()
    {
        startPosition = transform.localEulerAngles;
        helixDistance = topTransform.localPosition.y - (goalTransform.localPosition.y + .1f);
        //LoadStage(0);
        
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


    public void LoadStage(int stsgreNumber)
    {

    }


}
