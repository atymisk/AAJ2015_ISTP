using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LastPage : MonoBehaviour {
	public InputField inputfld;
	string activity = "";
	string behaviorexplain = "";
	void Awake () //resize upon instantiation
	{
		/*
		if(this.gameObject.name == "secondpagescripts")
		{
			return;
		}
		//btn and txt: 160 x 30
		//input: 184 x 82
		int bntxw = 160;
		int bntxh = 30;
		int inw = 184;
		int inh = 82;
		RectTransform rinp = (RectTransform)inputfld.transform.GetComponent<RectTransform>();
		RectTransform rtxt = (RectTransform)txt.transform.GetComponent<RectTransform>();
		RectTransform rbtn = (RectTransform)btn.transform.GetComponent<RectTransform>();

		if(Screen.height == 480)
		{
			bntxw = 160;
			inw = 244;
			bntxh = 30;
			inh = 82;
		}
		else
		{
			bntxw = 180;
			//inw = 264;
			bntxh = 40;
			inh = 92;
			switch(Screen.width)
			{
			case 359:
				inw = 274;
				break;
			case 374:
				inw = 286;
				break;
			case 383:
				inw = 292;
				break;
			case 399:
				inw = 320;
				break;
			case 425:
				inw = 350;
				break;
			default:
				break;
			}
		}

		rinp.sizeDelta = new Vector2(inw,inh);
		rtxt.sizeDelta = new Vector2(bntxw,bntxh);
		rbtn.sizeDelta = new Vector2(bntxw,bntxh);*/
	}
	
	public void done()//back to home page
	{
		if(behaviorexplain == "")
		{
			return;
		}
		//update the global for activity
		globals.behaviorexplain = behaviorexplain;
		//Debug.Log(globals.activitylogmsg);
		globals.timestamp = ""+System.DateTime.Now;
		globals.log();
		Application.LoadLevel("Home");
	}
	public void tothethird()//used by second page to move into next page
	{
		if(activity == "")
		{
			return;
		}
		//update the global for activity
		globals.activity = activity;
		Application.LoadLevel("chooseEmotion");
	}

	public void inputfield()
	{
		activity = inputfld.text;
		behaviorexplain = inputfld.text;
		//Debug.Log(inputfld.text);//append this data to something
	}
}
