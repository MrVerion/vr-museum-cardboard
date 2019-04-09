using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
   
    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        
    }

    void Update()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;

        Debug.DrawRay(ray.origin, ray.direction * 20, Color.yellow);
        if (Physics.Raycast(ray, out hit))
            Debug.Log("I'm looking at " + hit.collider.tag);
        else
          Debug.Log("I'm looking at nothing!");
           

      /* Physics.Raycast(ray, out hit);

        if (hit.collider != null && hit.collider.tag == "Wall")
        {
            
            GazeInputModule.cardboardPointer.OnGazeExit(cam, hit.transform.GetComponent<GameObject>());
            Debug.Log("Done");
        }
        else
            GazeInputModule.cardboardPointer.OnGazeEnabled();
            */
    }


}
