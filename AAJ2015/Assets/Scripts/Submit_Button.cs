using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Submit_Button : MonoBehaviour {
	GameObject explain;
	// Use this for initialization
	void Start () {
		explain = GameObject.Find ("ExplainBehavior");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void clickNow(){
		string text = explain.GetComponentInChildren<InputField> ().text;
		print (text);
		//update global on the behavior rating
		globals.behavior = text;
		Application.LoadLevel("Last");
		//check for text size, need min
	}
}
