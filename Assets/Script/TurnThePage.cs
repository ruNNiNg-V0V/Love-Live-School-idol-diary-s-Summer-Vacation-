using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnThePage : MonoBehaviour {

	public GameObject nameText;
	public GameObject sentenceText;

    public GameObject makiCharacter;
    public GameObject backgroundImage;


	List<string> sentenceTexts = new List<string>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
				if (Input.GetMouseButtonDown(0))
			for (int count = 0; count < 123456789;)
			{
				AddSentenceTexts ();

				nameText = GameObject.Find("NameText");
				sentenceText = GameObject.Find("SentenceText");

				sentenceText.GetComponent<Text>().text = sentenceTexts[count];

				count++;


			}
	}

	void AddSentenceTexts(){
		sentenceTexts.Add ("어라 설 늦잠, 잤나?");//1 ,half
		sentenceTexts.Add ("『시계를 보까, 아직 오전 6시도 되기전』");//2
		sentenceTexts.Add ("싫다. 쉬는 날일수록 일찍 일어나다니");//3
		sentenceTexts.Add ("이러면 꼭 호노카 같잖아!");//4
        sentenceTexts.Add("『창가로 다가갔더니 닫혀있는 레이스 커튼이\n 전혀 의미 없을 정도로 새하얗고 강렬한 햇살』");//5
        sentenceTexts.Add("우와~ 이런 날에 연습하러 나가면\n 까맣게 타버릴 거야, 분명!");//6 ,03
        sentenceTexts.Add("아, 그러고 보니\n 오늘은 연습 없었던가?");//7 ,05
        sentenceTexts.Add("『여름방학 첫날』");//8
        sentenceTexts.Add("『갑자기 찾아온 ...』");//9
        sentenceTexts.Add("『아니. 아마도 기다리고 기다리던,\n 개방적인 여름방학 첫째 날은 이렇게 시작되었습니다.』");//10
        sentenceTexts.Add("아 심심해!");//11 ,06
        sentenceTexts.Add("『아침 식사 뒤에도 무심코 빈둥거리며\n 식탁 의자에 낮아 있었어』");//12
        sentenceTexts.Add("『이런 식으로 의식하지 않았는데도\n 무심코 빈둥거리게 되는 게\n 여름방학의 나쁜 점이네』");//13
        sentenceTexts.Add("아아~ 빨리 여름 교습이라도\n시작하지 않으려나?");//14 ,half
    }

}
