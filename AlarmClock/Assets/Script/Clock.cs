using UnityEngine;
using System.Collections;
using System;

public class Clock : MonoBehaviour {

	private AudioSource audio1;
	private DateTime timeNow;



	void Start()
	{
		timeNow = DateTime.Now;
		audio1 = GetComponent<AudioSource> ();
	}

	void Update()
	{
		timeNow = DateTime.Now;
		if (timeNow.Hour.ToString ().Equals("15") && timeNow.Minute.ToString ().Equals("49") && timeNow.Second.ToString().Equals("0")) {
			Debug.Log ("Ring");
			ring ();
		}
	}

	void OnGUI(){
		String hour = timeNow.Hour.ToString ().PadLeft (2, '0');
		String minute = timeNow.Minute.ToString ().PadLeft (2, '0');
		String second = timeNow.Second.ToString ().PadLeft (2, '0');

		GUILayout.Label (hour + ":" + minute + ":" + second);
	}

	void ring()
	{
		audio1.Play ();
		Debug.Log ("actually rings");
		audio1.Play(44100);

	}
}
