using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Rate_Buttons : MonoBehaviour {
	GameObject rate;
	Button[] rateButtons;
	// Use this for initialization
	void Start () {
		rate = GameObject.Find ("Rate_Button");
		rateButtons = rate.GetComponentsInChildren<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void click(string name){
		foreach (Button b in rateButtons) {
			if(b.name.Equals(name)){
				if(b.GetComponent<Image>().color.Equals(Color.white))
					b.GetComponent<Image>().color = Color.red;
				else
					b.GetComponent<Image>().color = Color.white;
			}
			else
				b.GetComponent<Image>().color = Color.white;
		}
	}
}
