using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCheck : MonoBehaviour {

    public GameObject cam;

    public Canvas mainmenu;

    Vector3 vroom1 = new Vector3(-43.7f, 5f, 21.1f);
   Vector3 vroom2 = new Vector3(-15f, 5f, 30f);
   Vector3 vroom3 = new Vector3(-15f, 5f, -30f);
   Vector3 vroom4 = new Vector3(-43.7f, 5f, -21.1f);
   Vector3 vmainhall = new Vector3(-15f, 5f, 0f);

    

    GameObject[] croom1, croom2, croom3, croom4, cmainhall;

    // Use this for initialization
    void Start () {

        cmainhall = GameObject.FindGameObjectsWithTag("MainHall");
        croom1 = GameObject.FindGameObjectsWithTag("Room1");
        croom2 = GameObject.FindGameObjectsWithTag("Room2");
        croom3 = GameObject.FindGameObjectsWithTag("Room3");
        croom4 = GameObject.FindGameObjectsWithTag("Room4");
    }
	
	// Update is called once per frame
	void Update () {
		
        if (cam.transform.position != vmainhall)
        {
            foreach (GameObject go in cmainhall)
            {
                Collider cmh = go.GetComponent<Collider>();
                cmh.enabled = false;
            }

            if (cam.transform.position == vroom1)
            {
                foreach (GameObject go in croom1)
                {
                    Collider cr1 = go.GetComponent<Collider>();
                    cr1.enabled = true;

                }
            }

            if (cam.transform.position == vroom2)
            {
                foreach (GameObject go in croom2)
                {
                    Collider cr2 = go.GetComponent<Collider>();
                    cr2.enabled = true;

                }
            }

            if (cam.transform.position == vroom3)
            {
                foreach (GameObject go in croom3)
                {
                    Collider cr3 = go.GetComponent<Collider>();
                    cr3.enabled = true;

                }
            }

            if (cam.transform.position == vroom4)
            {
                foreach (GameObject go in croom4)
                {
                    Collider cr4 = go.GetComponent<Collider>();
                    cr4.enabled = true;

                }
            }

            mainmenu.enabled = false;
        }
        else
        { 
            foreach (GameObject go in cmainhall)
            {
                Collider cmh = go.GetComponent<Collider>();
                cmh.enabled = true;
            }

            foreach (GameObject go in croom1)
            {
                Collider cr1 = go.GetComponent<Collider>();
                cr1.enabled = false;

            }

            foreach (GameObject go in croom2)
            {
                Collider cr2 = go.GetComponent<Collider>();
                cr2.enabled = false;

            }

            foreach (GameObject go in croom3)
            {
                Collider cr3 = go.GetComponent<Collider>();
                cr3.enabled = false;

            }

            foreach (GameObject go in croom4)
            {
                Collider cr4 = go.GetComponent<Collider>();
                cr4.enabled = false;

            }

            mainmenu.enabled = true;

        }


    }
}
