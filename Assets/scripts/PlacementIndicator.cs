using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlacementIndicator : MonoBehaviour
{

    private ARRaycastManager arRayCastManager;
    private GameObject indicator;

    void Start()
        {
            arRayCastManager = FindObjectOfType<ARRaycastManager>();
            indicator = GameObject.FindGameObjectWithTag("indicator");
            indicator.SetActive(false);
        }

    void Update()
        {
            List<ARRaycastHit> hits = new List<ARRaycastHit>();
            arRayCastManager.Raycast(new Vector2(Screen.width/2, Screen.height/2), hits, TrackableType.Planes);

            if (hits.Count > 0)
            {
                transform.position = hits[0].pose.position;
                transform.rotation = hits[0].pose.rotation;
             
                if(!indicator.activeInHierarchy)
                {
                    indicator.SetActive(true);
                }
            }
        }
}
