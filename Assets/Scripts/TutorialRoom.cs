using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialRoom : MonoBehaviour {

    AudioSource tutroom1;
    Renderer rend;
    bool isActive;

    void Start()
    {
        tutroom1 = gameObject.GetComponent<AudioSource>();
        rend = transform.parent.GetComponent<Renderer>();
        isActive = false;
    }

	public void StartTutorialRoom()
    {
        if (isActive == false)
        {
            tutroom1.Play();
            isActive = true;
        }
        else
        {
            tutroom1.Stop();
            isActive = false;
        }
    }

    public void Hover()
    {
        rend.material.SetFloat("_Outline", 0.002f);
    }

    public void Unhover()
    {
        rend.material.SetFloat("_Outline", 0.0f);
    }

}
