using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class HomePage : MonoBehaviour 
{
	//globals{string activity,string emotion,int intensity,string behavior,int behavior_rating,string behavior explain}
	//ArrayList?
	//List?
	//Array?
	// Use this for initialization
	public Canvas canvas;
	public Button actlog;
	public Image img;
	public Image star;
	List<Button> logs = new List<Button>();
	void Start()
	{
		//DontDestroyOnLoad(this);
		star.rectTransform.anchoredPosition = new Vector2(Screen.width/4,-Screen.height+50);
	}
	void OnLevelWasLoaded () 
	{
		showlogs ();
	}

	//need to search for serializing data
	void showlogs()
	{
		//Debug.Log("method called");
		if(globals.list.Count == 0)
		{
			return;
		}
		//grab only the end of the static list
		List<globals.ActivityLogged> lisp = globals.list;
		lisp.Reverse();//start from the back, the most recent
		//globals.ActivityLogged mine = lisp[0];
		Button pref;// = (Button)Instantiate(actlog);
		for(int i=0;i<lisp.Count;i++)
		{
			pref = (Button)Instantiate(actlog);
			pref.transform.SetParent(canvas.transform);
			pref.transform.localScale = new Vector3(1,1,1);//resize to normalcy
			pref.GetComponentInChildren<Text>().text = lisp[i].logone;
			RectTransform rp = (RectTransform)pref.transform.GetComponent<RectTransform>();
			rp.sizeDelta = new Vector2(Screen.width-20,rp.sizeDelta.y);
			if(i==0)
			{
				rp.anchoredPosition = new Vector2(0,img.transform.position.y + (img.transform.GetComponent<RectTransform>().sizeDelta.y/2)+30);
			}
			else
			{
				RectTransform r =(RectTransform)logs[i-1].transform.GetComponent<RectTransform>();
				rp.anchoredPosition = new Vector2(0,r.anchoredPosition.y - (r.sizeDelta.y+10));
			}
			logs.Add(pref);
		}
	}
	void renderLogs()
	{
		//create copy of list and reverse it and then add buttons top to bottom
		//List<Button> lisp = globals.buttonlist;
		//lisp.Reverse();
/*
		lisp[0].transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(0,img.transform.position.y + (img.transform.GetComponent<RectTransform>().sizeDelta.y/2)+30);
		for(int i = 1; i < lisp.Count;i++)
		{
			lisp[i].transform.GetComponent<RectTransform>().anchoredPosition= new Vector2(0,lisp[i-1].transform.position.y + 10);
		}*/
	}

	public void transitionNext()
	{
		Application.LoadLevel("Second");//next page

		//Debug.Log(Screen.width + " x " + Screen.height);
	}

	public void viewActivity()
	{
		Debug.Log("activity being viewed");
	}
}
