using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnThePage : MonoBehaviour
{

    public int count;

    public GameObject nameText;
    //nameText = GameObject.Find("NameText");

    public GameObject sentenceText;
    //sentenceText = GameObject.Find("SentenceText");


    public GameObject maki;
    public GameObject makisurprised;
    public GameObject makidemonstrative;

    //public GameObject maki = GameObject.FindWithTag("maki"); 발생시점이 awake보다 먼저이기 때문에 에러가 있던 것

    // Use this for initialization
    void Start()
    {
        maki = GameObject.FindWithTag("maki");
        makisurprised = GameObject.FindWithTag("makisurprised");
        makidemonstrative = GameObject.FindWithTag("makidemonstrative");
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            nameText = GameObject.Find("NameText");
            sentenceText = GameObject.Find("SentenceText");

            count++;

            //GameObject dWP = Instantiate(dialogueWindowPrefab) as GameObject;
            //dWP.transform.position = new Vector3(-6, (float)-1.97, -8); 
            //틀이 아니라 텍스트만 설정해주면 됨 프리팹일 필요도 없음
            if (count == 1)
            {
                //maki = GameObject.FindWithTag("maki");
                maki.transform.position = new Vector3(0, 0, 4);
            }

            if (count == 2)
            {
                //nameText = GameObject.Find("NameText");
                nameText.GetComponent<Text>().text = "니시키노 마키";//빠저있던거
                //sentenceText = GameObject.Find("SentenceText");
                sentenceText.GetComponent<Text>().text = "어라 설마 늦잠, 잤나?";
            }
            if (count == 3)
            {
                sentenceText.GetComponent<Text>().text = "『시계를 보니까, 아직 오전 6시도 되기 전』";
                makisurprised.transform.position = new Vector3(0, 0, 3);
            }
            if (count == 4)
            {
                makidemonstrative.transform.position = new Vector3(0, 0, 2);
                sentenceText.GetComponent<Text>().text = "뭐야, 아직 이것 밖에 안 됐잖아!";

            }
        }

    }

}