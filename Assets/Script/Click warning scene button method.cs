using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickWarningSceneButtonMethod : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void clickedWarningSceneButton()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Chapter1");
        }

    }
}
