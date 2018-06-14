using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnThePage : MonoBehaviour
{
    public GameObject nameText;
    //nameText = GameObject.Find("NameText");

    public GameObject sentenceText;
    //sentenceText = GameObject.Find("SentenceText");


    private GameObject maki;
    private GameObject makisurprised;
    private GameObject makidemonstrative;
    private GameObject makireminded;

    private GameObject kitchen;

    //public GameObject maki = GameObject.FindWithTag("maki"); 발생시점이 awake보다 먼저이기 때문에 에러가 있던 것

    // Use this for initialization
    void Start()
    {
        maki = GameObject.FindWithTag("maki");
        makisurprised = GameObject.FindWithTag("makisurprised");
        makidemonstrative = GameObject.FindWithTag("makidemonstrative");
        makireminded = GameObject.FindWithTag("makireminded");

        kitchen = GameObject.FindWithTag("Kitchen");

    }

    // Update is called once per frame
    void Update()
    {
        for (int count = 0; count < 123456789;)
        {
            if (Input.GetMouseButtonDown(0))
            {
                count++;

                nameText = GameObject.Find("NameText");
                sentenceText = GameObject.Find("SentenceText");

                if (count == 1)
                {
                    //maki = GameObject.FindWithTag("maki");
                    maki.transform.position = new Vector3(0, 0, -1);
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
                    makisurprised.transform.position = new Vector3(0, 0, -2);
                }
                if (count == 4)
                {
                    makidemonstrative.transform.position = new Vector3(0, 0, -3);
                    sentenceText.GetComponent<Text>().text = "뭐야, 아직 이것 밖에 안 됐잖아!";

                }
                if (count == 5)
                {
                    maki.transform.position = new Vector3(0, 0, -4);
                    sentenceText.GetComponent<Text>().text = "싫다. 쉬는 날일수록 일찍 일어나다니 \n이러면 꼭 호노카 같잖아!";
                }
                if (count == 6)
                {
                    makisurprised.transform.position = new Vector3(0, 0, -5);
                    sentenceText.GetComponent<Text>().text = "『창가로 다가갔더니 닫혀있는 레이스 커튼이\n 전혀 의미 없을 정도로 새하얗고 강렬한 햇살』";
                }
                if (count == 7)
                {
                    sentenceText.GetComponent<Text>().text = "우와~ 이런 날에 연습하러 나가면\n까맣게 타버릴 거야, 분명!";
                }
                if (count == 8)
                {
                    makireminded.transform.position = new Vector3(0, 0, -6);
                    sentenceText.GetComponent<Text>().text = "아, 그러고 보니\n오늘은 연습 없었던가?";
                }
                if (count == 9)
                {
                    sentenceText.GetComponent<Text>().text = "『여름방학 첫날』";
                }
                if (count == 10)
                {
                    sentenceText.GetComponent<Text>().text = "『갑자기 찾아온 ...』";
                }
                if (count == 11)
                {
                    sentenceText.GetComponent<Text>().text = "『아니. 아마도 기다리고 기다리던,\n 개방적인 여름방학 첫째 날은 이렇게 시작되었습니다』";
                }

                if (count == 12)
                {
                    kitchen.transform.position = new Vector3(0, 0, 0);
                    makidemonstrative.transform.position = new Vector3(0, 0, -7);
                    sentenceText.GetComponent<Text>().text = "아 심심해!";
                }
                if (count == 13)
                {
                    sentenceText.GetComponent<Text>().text = "『아침 식사 뒤에도 무심코 빈둥거리며\n 식탁 의자에 낮아 있었어』";
                }
                if (count == 14)
                {
                    sentenceText.GetComponent<Text>().text = "『이런 식으로 의식하지 않았는데도\n 무심코 빈둥거리게 되는 게\n 여름방학의 나쁜 점이네』";
                }
                if (count == 15)
                {
                    maki.transform.position = new Vector3(0, 0, (float)-7.1);
                    sentenceText.GetComponent<Text>().text = "『아아~ 빨리 여름 교습이라도\n 시작하지 않으려나?』";
                }
            }
        }
    }
}

