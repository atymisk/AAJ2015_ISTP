using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class thirdpageresize : MonoBehaviour {
	public Button[] btn = new Button[6];//all buttons
	public Image up;
	public Image down;
	public InputField inp;
	public Text txt1;
	public Text txt2;
	// Use this for initialization
	void Awake()
	{
		//get all rect transforms
		RectTransform[] rbtn = new RectTransform[6];
		for(int i = 0; i < btn.Length; i++)
		{
			rbtn[i] = (RectTransform)btn[i].transform.GetComponent<RectTransform>();
		}
		RectTransform rup = up.rectTransform;
		RectTransform rdown = down.rectTransform;
		RectTransform rinp = (RectTransform)inp.transform.GetComponent<RectTransform>();
		RectTransform rtxt1 = txt1.rectTransform;
		RectTransform rtxt2 = txt2.rectTransform;
		/*
		 * btn: 30 x 30
		 * up & down: 75 x 60
		 * inp: 225 x 100
		 * submit: 160 x 30
		 * txt1: 214 x 30
		 * txt2: 230 x 30
		 */
		int xoffset = 0;
		int secondxoff = 0;
		int yoffset = 0;
		int btnwh = 30;
		int updownw = 75;
		int updownh = 60;
		int inpw = 280;
		int inph = 100;
		int txtw = 214;

		if(Screen.height != 480)
		{
			inph = 130;
			updownh = 60;
			yoffset = 20;
		}
		switch(Screen.width)
		{
		case 359:
			btnwh = 37;
			updownw = 75;
			inpw = 336;
			txtw = 240;
			xoffset = 13;
			secondxoff = xoffset+12;
			break;
		case 374:
			btnwh = 39;
			updownw = 75;
			inpw = 328;
			txtw = 240;
			xoffset = 17;
			secondxoff = xoffset+10;
			break;
		case 383:
			btnwh = 42;
			updownw = 75;
			inpw = 336;
			txtw = 240;
			xoffset = 19;
			secondxoff = xoffset+12;
			break;
		case 399:
			btnwh = 42;
			updownw = 75;
			inpw = 336;
			txtw = 240;
			xoffset = 19;
			secondxoff = xoffset+12;
			break;
		case 425:
			btnwh = 44;
			updownw = 75;
			inpw = 378;
			txtw = 240;
			xoffset = 22;
			secondxoff = xoffset+16;
			break;
		default:
			break;
		}

		rup.sizeDelta = new Vector2(updownw,updownh);
		rup.anchoredPosition = new Vector2(rup.anchoredPosition.x+secondxoff,rup.anchoredPosition.y+yoffset);

		rdown.sizeDelta = new Vector2(updownw,updownh);
		rdown.anchoredPosition = new Vector2(rdown.anchoredPosition.x-secondxoff,rdown.anchoredPosition.y+yoffset);

		rinp.sizeDelta = new Vector2(inpw,inph);
		rinp.anchoredPosition = new Vector2(rinp.anchoredPosition.x,rinp.anchoredPosition.y);

		rtxt1.sizeDelta = new Vector2(txtw,btnwh);
		rtxt1.anchoredPosition = new Vector2(rtxt1.anchoredPosition.x,rtxt1.anchoredPosition.y+yoffset);

		rtxt2.sizeDelta = new Vector2(txtw,btnwh);
		rtxt2.anchoredPosition = new Vector2(rtxt2.anchoredPosition.x,rtxt2.anchoredPosition.y+yoffset);

		rbtn[5].sizeDelta = new Vector2(inph,btnwh);//submit
		rbtn[5].anchoredPosition = new Vector2(rbtn[5].anchoredPosition.x,rbtn[5].anchoredPosition.y-(yoffset+20));

		rbtn[0].sizeDelta = new Vector2(btnwh,btnwh);
		rbtn[0].anchoredPosition = new Vector2(rbtn[0].anchoredPosition.x-secondxoff,rbtn[0].anchoredPosition.y+yoffset);

		rbtn[1].sizeDelta = new Vector2(btnwh,btnwh);
		rbtn[1].anchoredPosition = new Vector2(rbtn[1].anchoredPosition.x-xoffset,rbtn[1].anchoredPosition.y+yoffset);

		rbtn[2].sizeDelta = new Vector2(btnwh,btnwh);
		rbtn[2].anchoredPosition = new Vector2(rbtn[2].anchoredPosition.x,rbtn[2].anchoredPosition.y+yoffset);

		rbtn[3].sizeDelta = new Vector2(btnwh,btnwh);
		rbtn[3].anchoredPosition = new Vector2(rbtn[3].anchoredPosition.x+xoffset,rbtn[3].anchoredPosition.y+yoffset);

		rbtn[4].sizeDelta = new Vector2(btnwh,btnwh);
		rbtn[4].anchoredPosition = new Vector2(rbtn[4].anchoredPosition.x+secondxoff,rbtn[4].anchoredPosition.y+yoffset);
	}
}
