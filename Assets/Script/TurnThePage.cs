using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnThePage : MonoBehaviour {

    public int count;

    public GameObject nameText;
    public GameObject sentenceText;

    public GameObject maki;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            count++;

            //GameObject dWP = Instantiate(dialogueWindowPrefab) as GameObject;
            //dWP.transform.position = new Vector3(-6, (float)-1.97, -8); 
            //틀이 아니라 텍스트만 설정해주면 됨 프리팹일 필요도 없음
            if (count == 1)
            {
                maki = GameObject.FindWithTag("maki");
                maki.transform.Translate(0,12,0);
            }

            if (count == 2)
            {
                nameText = GameObject.Find("NameText");
                nameText.GetComponent<Text>().text = "니시키노 마키";//빠저있던거
                sentenceText = GameObject.Find("SentenceText");
                sentenceText.GetComponent<Text>().text = "어라 설마 늦잠, 잤나?";
            }
        }
    }

}