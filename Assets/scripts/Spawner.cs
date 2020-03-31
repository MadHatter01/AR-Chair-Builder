using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private PlacementIndicator indicator;
    public GameObject ObjectToPlace;

    void Start()
        {
            indicator = FindObjectOfType<PlacementIndicator>();
        }

    void Update()
        {
            if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {
            Debug.Log("Instantiated)");
                GameObject obj = Instantiate(ObjectToPlace, indicator.transform.position, indicator.transform.rotation);
            }
        }
}
