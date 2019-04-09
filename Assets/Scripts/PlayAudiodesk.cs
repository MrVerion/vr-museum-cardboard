using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudiodesk : MonoBehaviour
{


    bool IsActive;

    public AudioSource sound;

    public GameObject play, stop;
    Renderer render, red, green;


    // Use this for initialization
    void Start()
    {

      

        render = gameObject.GetComponent<Renderer>();
        green = play.GetComponent<Renderer>();
        red = stop.GetComponent<Renderer>();

        IsActive = false;

    }

   

    public void PlayAudiodeskVR()
    {    
        StartCoroutine(AudiodeskPlay(play));
        

    }

    public void StopAudiodeskVR()
    {
        green.material.SetColor("_EmissionColor", Color.black);
        play.GetComponent<Collider>().enabled = true;
        sound.Stop();
        IsActive = false;
    }

    public void Hover()
    {
        render.material.SetFloat("_Outline", 0.008f);
    }

    public void Unhover()
    {
      
        render.material.SetFloat("_Outline", 0f);

    }

    public void ActiveGreen()
    {
        green.material.SetColor("_EmissionColor", Color.green);

    }

    public void ActiveRed()
    {
        red.material.SetColor("_EmissionColor", Color.red);
    }

    public void Unactive()
    {
        if (IsActive == false)
        {
            green.material.SetColor("_EmissionColor", Color.black);
            red.material.SetColor("_EmissionColor", Color.black);
        }
        else
        {     
            green.material.SetColor("_EmissionColor", Color.yellow);
            red.material.SetColor("_EmissionColor", Color.black);
        }

    }

    IEnumerator AudiodeskPlay(GameObject g1)
    {

        sound.Play();
        green.material.SetColor("_EmissionColor", Color.yellow);
        g1.GetComponent<Collider>().enabled = false;
        IsActive = true;

        while (sound.isPlaying)
        {
            yield return null;
        }

        green.material.SetColor("_EmissionColor", Color.black);
        play.GetComponent<Collider>().enabled = true;
        IsActive = false;
        

    }
}