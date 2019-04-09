using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToRoom2 : MonoBehaviour {

   
    public GameObject vrcamera;
    Renderer rend;
    AudioSource audio;

    // Use this for initialization
    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
        audio = gameObject.GetComponent<AudioSource>();
    }

    public void moveCameraRoom2()
    {
        vrcamera.transform.position = new Vector3(-15f, 5f, 30f);
    }



    public void Hover()
    {
        rend.material.SetFloat("_Outline", 0.08f);
        audio.Play();
    }

    public void Unhover()
    {
        rend.material.SetFloat("_Outline", 0f);
        audio.Stop();
    }
}
