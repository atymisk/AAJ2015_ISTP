using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class secondpageresize : MonoBehaviour {
	public InputField inp;
	public Text txt;
	public Button btn;

	// Use this for initialization
	void Awake () 
	{
		//print (Screen.width + " x " + Screen.height);
		//inputfield: 160 x 30
		//text ^
		//btn: 62 x 26
		int ctw = 160;//default sizes
		int cth = 30;//txt and inp share same aspect ratio
		int btnw = 62;
		int btnh = 26;
		int hoffset = 0;

		if(Screen.width == 320)
		{
			ctw = 200;
			btnw = 62;
			cth = 32;
			btnh = 26;
		}
		else
		{
			ctw = 190;
			btnw = 80;
			cth = 50;
			btnh = 38;
			hoffset = 8;
		}
		RectTransform rinp = (RectTransform)inp.transform.GetComponent<RectTransform>();
		RectTransform rtxt = (RectTransform)txt.transform.GetComponent<RectTransform>();
		RectTransform rbtn = (RectTransform)btn.transform.GetComponent<RectTransform>();

		rinp.sizeDelta = new Vector2(Screen.width-8,cth-hoffset);
		rtxt.sizeDelta = new Vector2(ctw,cth);
		rbtn.sizeDelta = new Vector2(btnw,btnh);

	}
}
