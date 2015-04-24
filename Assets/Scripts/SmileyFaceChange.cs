using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class SmileyFaceChange : MonoBehaviour {
	// Use this for initialization
	int intensity = 1;
	public Image smileyIntensity;

	public Sprite smileyIntensityOne;
	public Sprite smileyIntensityTwo;
	public Sprite smileyIntensityThree;

	void Start ()
	{
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
		print ("Request Submitted. Intensity level = " + intensity);
	}

}
