using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class emotion_Buttons : MonoBehaviour {
	public Text txt;
	public Button b;
	GameObject emotion;
	Button[] emotionButtons;
	Text emotionText;
	string emote = "";
	// Use this for initialization
	void Awake () {
		emotion = GameObject.Find ("emotionButtons");
		emotionButtons = emotion.GetComponentsInChildren<Button> ();
		/*
		RectTransform[] rbtn = new RectTransform[emotionButtons.Length];
		RectTransform rtxt = txt.rectTransform;
		RectTransform robtn = (RectTransform)b.transform.GetComponent<RectTransform>();

		int offset = 0;
		int btnwh = 50;
		int txtw = 215;
		int subw = 70;
		int subh = 30;
		if(Screen.height != 480)
		{
			btnwh = 60;
			txtw = 230;
			offset = 22;
			subw = 88;
			subh = 40;
		}
		for(int i=0; i<rbtn.Length;i++)
		{
			rbtn[i] = (RectTransform)emotionButtons[i].transform.GetComponent<RectTransform>();
			rbtn[i].sizeDelta = new Vector2(btnwh,btnwh);
		}
		robtn.sizeDelta = new Vector2(subw,subh);
		rtxt.sizeDelta = new Vector2(txtw,btnwh);
		rtxt.anchoredPosition = new Vector2(rtxt.anchoredPosition.x, rtxt.anchoredPosition.y +(offset*2));
		rbtn[0].anchoredPosition = new Vector2(rbtn[0].anchoredPosition.x,rbtn[0].anchoredPosition.y);
		rbtn[1].anchoredPosition = new Vector2(rbtn[1].anchoredPosition.x- offset,rbtn[1].anchoredPosition.y+offset);
		rbtn[2].anchoredPosition = new Vector2(rbtn[2].anchoredPosition.x+offset,rbtn[2].anchoredPosition.y-offset);*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void click(string name){
		emote = name;
		foreach (Button b in emotionButtons) {
			emotionText = b.GetComponentInChildren<Text>();
			if(b.name.Equals(name)){
				if(emotionText.color.Equals(Color.white))
				{
					emotionText.color = Color.red;
				}
				else
					emotionText.color = Color.white;
			}
			else
				emotionText.color = Color.white;
		}
	}
	public void submit()
	{
		//Debug.Log(emote);
		if(emote == "happyButton")
		{
			//updating global on emotion
			globals.emotion = emote;
			Application.LoadLevel("happyOption");
		}
		else if(emote == "sadButton")
		{
			//updating global on emotion
			globals.emotion = emote;
			Application.LoadLevel("sadOption");
		}
		else if(emote == "angryButton")
		{
			//updating global on emotion
			globals.emotion = emote;
			Application.LoadLevel("angryOption");
		}
		else
		{
			Debug.Log("error");
		}
	}
}
