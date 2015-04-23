using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class emotion_Buttons : MonoBehaviour {
	GameObject emotion;
	Button[] emotionButtons;
	Text emotionText;
	// Use this for initialization
	void Start () {
		emotion = GameObject.Find ("emotionButtons");
		emotionButtons = emotion.GetComponentsInChildren<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void click(string name){
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
}
