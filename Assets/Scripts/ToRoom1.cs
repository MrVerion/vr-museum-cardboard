using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToRoom1 : MonoBehaviour {

    public GameObject vrcamera;

    Renderer rend;
    AudioSource audiodesc;

    // Use this for initialization
    void Start () {
        rend = gameObject.GetComponent<Renderer>();
        audiodesc = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void moveCameraRoom1()
    {
        vrcamera.transform.position = new Vector3(-43.7f, 5f, 21.1f);
    }

    public void Hover()
    {
        rend.material.SetFloat("_Outline", 0.08f);
        audiodesc.Play();
    }

    public void Unhover()
    {
        rend.material.SetFloat("_Outline", 0f);
        audiodesc.Stop();
    }
}
