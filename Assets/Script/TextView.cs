using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextView : MonoBehaviour
{

    public int count;

    public GameObject nameText;
    public GameObject sentenceText;

    void ReplaceTextView()
    {
        if (Input.GetMouseButtonDown(0))
        {
            count++;

            if (count == 1)
            {
                nameText = GameObject.Find("NameText");
                nameText.GetComponent<Text>().text = "니시키노 마키";//빠저있던거
            }
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}