using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class SmileyFaceChange : MonoBehaviour {
	// Use this for initialization
	int intensity = 0;
	public Image smileyIntensity;
	public Sprite smileyIntensityOne;
	public Sprite smileyIntensityTwo;
	public Sprite smileyIntensityThree;
	/*

	public Button[] btn = new Button[4];
*/	
	void Awake ()
	{
		/*
		//get all recttransforms from all relevant objects
		RectTransform rimg = smileyIntensity.rectTransform;
		RectTransform[] rbtn = new RectTransform[4];
		for(int i=0;i<btn.Length;i++)
		{
			rbtn[i] = (RectTransform)btn[i].transform.GetComponent<RectTransform>();
		}
		/*
		 * btn 0 - 2: 40x40
		 * smiley: 80x80
		 * submit: 50x30
		 *
		int imgwh = 80;
		int btnwh = 40;
		int otherbtnw = 50;
		int otherbtnh = 30;
		int xoffset = 0;
		if(Screen.height != 480)
		{
			otherbtnh = 40;
			imgwh = 100;
			btnwh = 60;
			otherbtnw = 80;
			xoffset = 18;
		}

		rimg.sizeDelta = new Vector2(imgwh,imgwh);
		for(int i=0;i<3;i++)
		{
			rbtn[i].sizeDelta = new Vector2(btnwh,btnwh);
		}
		rimg.anchoredPosition = new Vector2(rimg.anchoredPosition.x,rimg.anchoredPosition.y+xoffset);
		rbtn[0].anchoredPosition = new Vector2(rbtn[0].anchoredPosition.x-xoffset,rbtn[0].anchoredPosition.y);
		rbtn[2].anchoredPosition = new Vector2(rbtn[2].anchoredPosition.x+xoffset,rbtn[2].anchoredPosition.y);
		rbtn[3].sizeDelta = new Vector2(otherbtnw,otherbtnh);
		rbtn[3].anchoredPosition = new Vector2(rbtn[3].anchoredPosition.x,rbtn[3].anchoredPosition.y-xoffset);*/
	}
	

	// Changes face to level 1 of happy
	public void changeone()
	{
		smileyIntensity.sprite = smileyIntensityOne;
		intensity = 1;
	}

	// Changes face to level 2 of happy
	public void changetwo()
	{
		smileyIntensity.sprite = smileyIntensityTwo;
		intensity = 2;
	}

	// Changes face to level 3 of happy
	public void changethree()
	{
		smileyIntensity.sprite = smileyIntensityThree;
		intensity = 3;
	}

	public void submit()
	{
		//print ("Request Submitted. Intensity level = " + intensity);
		if(intensity == 0)
		{
			return;
		}
		//update global on intensity
		globals.intensity = intensity;
		Application.LoadLevel("rateBehavior");
	}

}
