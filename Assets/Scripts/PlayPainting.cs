using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPainting : MonoBehaviour
{

    public Transform head;

    private Vector3 startposition;
    private Quaternion startrotation;

    private bool IsClicked;

    private AudioSource sound;

    private Renderer rend;



    // Use this for initialization
    void Start()
    {

        sound = GetComponent<AudioSource>();
        startposition = transform.position;
        startrotation = transform.rotation;

        IsClicked = false;

        rend = transform.parent.GetComponent<Renderer>();
    }

    public void PlayAudioVR()
    {
        if (IsClicked == false)
        {

            transform.rotation = new Quaternion(0.0f,
                head.transform.rotation.y,
                0.0f,
                head.transform.rotation.w);

            transform.position = head.position + (head.forward * 4);

            sound.Play();

            IsClicked = true;
        }

        else
        {
            transform.position = startposition;
            transform.rotation = startrotation;

            sound.Stop();

            IsClicked = false;
        }


    }

    public void Hover()
    {
        rend.material.SetFloat("_Outline", 0.008f);
    }

    public void StopAudioVR()
    {

        transform.position = startposition;
        transform.rotation = startrotation;

        sound.Stop();

        rend.material.SetFloat("_Outline", 0f);

    }



}
