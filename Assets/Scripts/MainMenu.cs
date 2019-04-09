using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

   
    public Slider audiovolume;
    public Button tutorial;
    public Toggle VRmode;
    public GameObject es1, es2, es3, es4, exit;
    public AudioClip tut1, tut2, tut3, tut4;
    private Renderer r1, r2, r3, r4, r5;

    public AudioSource maintutorial;



    // Use this for initialization
    void Start()
    {
        //aud = speaker.GetComponent<AudioSource>();
        r1 = es1.GetComponent<Renderer>();
        r2 = es2.GetComponent<Renderer>();
        r3 = es3.GetComponent<Renderer>();
        r4 = es4.GetComponent<Renderer>();
        r5 = exit.GetComponent<Renderer>();


    }

    public void StartTutorial()
    {
        
        StartCoroutine(Tutorial1(r1,r2,r3,r4,r5));

    }

    public void ChangeVolume(float audvalue)
    {
        AudioListener.volume = audvalue;      
    }

    public void ToggleVR()
    {
        Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
    }

   

    IEnumerator Tutorial1(Renderer r1, Renderer r2, Renderer r3, Renderer r4, Renderer r5)
    {

        es1.GetComponent<Collider>().enabled = false;
        es2.GetComponent<Collider>().enabled = false;
        es3.GetComponent<Collider>().enabled = false;
        es4.GetComponent<Collider>().enabled = false;
        exit.GetComponent<Collider>().enabled = false;

        maintutorial.clip = tut1;
        maintutorial.Play();

        yield return new WaitForSeconds(maintutorial.clip.length);

        maintutorial.clip = tut2;
        r1.material.SetFloat("_Outline", 0.1f);
        r2.material.SetFloat("_Outline", 0.1f);
        r3.material.SetFloat("_Outline", 0.1f);
        r4.material.SetFloat("_Outline", 0.1f);
        maintutorial.Play();

        yield return new WaitForSeconds(maintutorial.clip.length);

        maintutorial.clip = tut3;
        r1.material.SetFloat("_Outline", 0f);
        r2.material.SetFloat("_Outline", 0f);
        r3.material.SetFloat("_Outline", 0f);
        r4.material.SetFloat("_Outline", 0f); 
        r5.material.SetFloat("_Outline", 0.05f);
        maintutorial.Play();

        yield return new WaitForSeconds(maintutorial.clip.length);

        maintutorial.clip = tut4;
        r5.material.SetFloat("_Outline", 0f);
        maintutorial.Play();

        es1.GetComponent<Collider>().enabled = true;
        es2.GetComponent<Collider>().enabled = true;
        es3.GetComponent<Collider>().enabled = true;
        es4.GetComponent<Collider>().enabled = true;
        exit.GetComponent<Collider>().enabled = true;

    }

}
