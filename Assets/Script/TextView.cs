using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextView : MonoBehaviour
{

    public int count;

    public GameObject dialogueWindowPrefab;

    public GameObject nameText;
    public GameObject sentenceText;

    void ReplaceTextView()
    {
        if (Input.GetMouseButtonDown(0))
        {
            count++;

            GameObject dWP = Instantiate(dialogueWindowPrefab) as GameObject;
            dWP.transform.position = new Vector3(-6, (float)-1.97, -8);
            dWP.transform.localScale = new Vector3((float)2.4, (float)2.5, 1);

            if (count == 1)
            {
                nameText = GameObject.Find("NameText");
                nameText.GetComponent<Text>().text = "니시키노 마키";//빠저있던거
                sentenceText = GameObject.Find("SentenceText");
                sentenceText.GetComponent<Text>().text = "어라 설마 늦잠, 잤나?";
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