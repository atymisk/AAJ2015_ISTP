using UnityEngine;
using System.Collections;

public class positioning : MonoBehaviour {

	// Use this for initialization
	public GameObject actlog;
	
	void Awake () 
	{
		//Screen-Height:400 min, 638 max
		//Screen-Width: 320 min, 359, 374, 383, 399, 425 max
		//Debug.Log(Screen.width + " x " + Screen.height);
		int sdelt_w = 135;
		int sdelt_h;
		int other_w = 190;
		int other_h = 39;
		int xoffset = 0;

		switch(Screen.width)
		{
		case 320:
			sdelt_w = 135;
			other_w = 190;
			xoffset = -10;
			break;
		case 359:
			sdelt_w = 162;
			other_w = 205;
			xoffset = -18;
			break;
		case 374:
			sdelt_w = 165;
			other_w = 220;
			xoffset = -16;
			break;
		case 383:
			sdelt_w = 168;
			other_w = 220;
			xoffset = -16;
			break;
		case 399:
			sdelt_w = 181;
			other_w = 225;
			xoffset = -20;
			break;
		case 425:
			sdelt_w = 192;
			other_w = 225;
			xoffset = -21;
			break;
		default:
			break;
		}

		if(Screen.height == 480)
		{
			//do something
			sdelt_h = 125;
			other_h = 39;
		}
		else
		{
			//do something
			sdelt_h = 155;
			other_h = 47;
		}

		RectTransform rtrans = (RectTransform)transform.GetComponent<RectTransform>();
		if(this.gameObject.name == "actlog")
		{
			rtrans.anchoredPosition = new Vector2(0,Screen.height/2.25f);
			//adjust the width and height
			rtrans.sizeDelta = new Vector2(sdelt_w,sdelt_h);
		}
		else if(this.gameObject.name == "New_Activity")
		{
			RectTransform rtact = (RectTransform)actlog.transform.GetComponent<RectTransform>();
			rtrans.anchoredPosition = new Vector2(rtact.sizeDelta.x+xoffset,Screen.height/2.25f);
			//adjust the width and height
			rtrans.sizeDelta = new Vector2(other_w,other_h);
		}
	}
	

}
