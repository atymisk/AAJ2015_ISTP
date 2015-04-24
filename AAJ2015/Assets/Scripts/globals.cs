using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public static class globals
{
	public static string activity = "";
	public static string emotion = "";
	public static int intensity = -1;
	public static int behaviorrate = -1;
	public static string behavior = "";
	public static string behaviorexplain = "";
	public static string timestamp = "";
	//need timestamp
	public static string activitylogmsg="";
	public static string singleline = "";
	//public static List<Button> buttonlist = new List<Button>();
	public struct ActivityLogged
	{
		public string activity;
		public string emotion;
		public int intensity;
		public int behaviorrate;
		public string behavior;
		public string behaviorexplain;
		public string timestmp;
		public string actlogmsg;
		public string logone;
		public ActivityLogged(string ac,string em,int inte,int behar,string behav,string behavirx,string tmstp,string actlo,string one)
		{
			activity = ac;
			emotion = em;
			intensity = inte;
			behaviorrate = behar;
			behavior = behav;
			behaviorexplain = behavirx;
			timestmp = tmstp;
			actlogmsg = actlo;
			logone = one;
		}
	};
	public static List<ActivityLogged> list = new List<ActivityLogged>();
	public static void resetvalues()
	{
		activity = "";
		emotion = "";
		intensity = -1;
		behaviorrate = -1;
		behavior = "";
		behaviorexplain = "";
		timestamp = "";
		activitylogmsg = "";
	}
	public static void log()
	{
		if(emotion == "happyButton")
		{
			emotion = "Happy\n";
		}
		else if(emotion == "sadButton")
		{
			emotion = "Sad\n";
		}
		else if(emotion == "angryButton")
		{
			emotion = "Angry and/or Upset\n";
		}
		singleline = timestamp + " | Activity: " + activity + " | Emotion Range: "+emotion+" | Emotional Intensity: " + 
				intensity + " | Behavior During Activity: " + behavior + " | Self-rating of Behavior: " + behaviorrate +
				" | Explanation of Behavior: " + behaviorexplain;
		activitylogmsg = timestamp + "\nActivity: " + activity + "\nEmotion Range: " + emotion + 
			"Emotional Intensity: " + intensity + "\nBehavior During Activity: " + behavior 
				+ "\nSelf-rating of Behavior: " + behaviorrate + "\nExplanation of Behavior: " + behaviorexplain;
		ActivityLogged entry = new ActivityLogged(activity,emotion,intensity,
		                                          behaviorrate,behavior,behaviorexplain,timestamp,activitylogmsg,singleline);
		list.Add(entry);
		resetvalues();
	}
}
