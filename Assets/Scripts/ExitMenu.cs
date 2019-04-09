using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitMenu : MonoBehaviour {

    Canvas exitmenu;

    void Start () {

        exitmenu = gameObject.GetComponent<Canvas>();
        exitmenu.enabled = false;
	}
	

    public void OpenExitMenu()
    {
        exitmenu.enabled = true;
    }

    public void YesExit()
    {
        Application.Quit();
    }

    public void NoExit()
    {
        exitmenu.enabled = false;
    }

        
    

}
