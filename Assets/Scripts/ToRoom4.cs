using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToRoom4 : MonoBehaviour
{
    public GameObject vrcamera;
    Renderer rend;
    AudioSource audio;

    // Use this for initialization
    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
        audio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void moveCameraRoom4()
    {
        vrcamera.transform.position = new Vector3(-43.7f, 5f, -21.1f);
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
