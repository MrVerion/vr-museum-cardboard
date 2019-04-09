using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToMainHall : MonoBehaviour {

    public GameObject vrcamera;

    Renderer rend;

    // Use this for initialization
    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
    }

    public void moveCameraMainHall()
    {
        vrcamera.transform.position = new Vector3(-15f, 5f, 0f);
    }

    public void Hover()
    {
        rend.material.SetFloat("_Outline", 0.0005f);
    }

    public void Unhover()
    {
        rend.material.SetFloat("_Outline", 0f);
    }




}


