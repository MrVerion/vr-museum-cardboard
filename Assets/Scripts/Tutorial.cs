
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{

    public AudioSource tut1, tut2, tut3;
    GameObject arrow;
    bool tutorial;
    

    Vector3 r1 = new Vector3(-43.7f, 5f, 21.1f);
    Vector3 r2 = new Vector3(-15f, 5f, 30f);
    Vector3 r3 = new Vector3(-15f, 5f, -30f);
    Vector3 r4 = new Vector3(-43.7f, 5f, -21.1f);
    Vector3 mh = new Vector3(-15f, 5f, 0f);

    public GameObject cam;
    

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    /*public void startTutorial()
    {
        tut1.Play();

        if (cam.transform.position == r1 || 
            cam.transform.position == r2 || 
            cam.transform.position == r3 || 
            cam.transform.position == r4)

        {
            tut1.Stop();
            tut2.Play();
        }

        if (cam.transform.position == mh)
        {
            tut2.Play();
            tut3.Play();
        }
        

    }*/

        void startTutorial()
    {
        tut1.Play();
        StartCoroutine(TutorialMainHall(arrow));
    }

    IEnumerator TutorialMainHall(GameObject other)
    {
        //Wait Until Sound has finished playing
        while (tut1.isPlaying)
        {
            yield return null;
        }
       
        
    }
}
