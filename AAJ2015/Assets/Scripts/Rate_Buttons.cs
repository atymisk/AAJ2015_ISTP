using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Rate_Buttons : MonoBehaviour {
	GameObject rate;
	Button[] rateButtons;
	int rating = 0;
	// Use this for initialization
	void Start () {
		rate = GameObject.Find ("Rate_Button");
		rateButtons = rate.GetComponentsInChildren<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void click(string name)
	{
		int i = 1;
		foreach (Button b in rateButtons) {
			i++;
			if(b.name.Equals(name)){
				if(b.GetComponent<Image>().color.Equals(Color.white))
				{
					b.GetComponent<Image>().color = Color.red;
					rating = i-1;
				}
				else
					b.GetComponent<Image>().color = Color.white;
			}
			else
				b.GetComponent<Image>().color = Color.white;
		}
		//Debug.Log(rating);
		globals.behaviorrate = rating;
	}
}
