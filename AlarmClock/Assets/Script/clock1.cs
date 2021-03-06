﻿using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clock1 : MonoBehaviour
{

	private AudioSource audio1;
	private DateTime timeNow;
	public Dropdown hour1;
	public Dropdown minute1;
	public Button b1;
	public Button b2;
	public GameObject canvas;
	public GameObject canvas0;

	private bool selected;
	private int count = 0;

	private String hour_string;
	private String minute_string;

	void Start()
	{
		Calarm.askForUserPermitCS ();
		Application.runInBackground = true;
		timeNow = DateTime.Now;
		audio1 = GetComponent<AudioSource>();

		Button b = b1.GetComponent<Button>();
		b.onClick.AddListener(() => actionOnClick(b));

		Button c = b2.GetComponent<Button>();
		c.onClick.AddListener(() => actionOnClick2(c));

		selected = false;


	}

	void Update()
	{
		timeNow = DateTime.Now;
		if (timeNow.Hour.ToString().Equals(hour_string) && timeNow.Minute.ToString().Equals(minute_string) && timeNow.Second.ToString().Equals("0"))
		{

			if (count ==0){
			Debug.Log("Ring");
			ring();
		    }
			count++;
			    
		}
	}

	void OnGUI()
	{
		String hour = timeNow.Hour.ToString().PadLeft(2, '0');
		String minute = timeNow.Minute.ToString().PadLeft(2, '0');
		String second = timeNow.Second.ToString().PadLeft(2, '0');

		GUILayout.Label(hour_string + ":" + minute_string + ":" + second);
	}

	void ring()
	{
//		audio1.Play();
//		Debug.Log("actually rings");
//		audio1.Play(44100);
//		SceneManager.LoadScene("Login");

	}


	void actionOnClick(Button b)
	{
		Debug.Log("Success click");

		//get the hour and int in the dropdown selection
		int hour_int = 0;
		int minute_int = 0;

		hour_string = hour1.GetComponent<Dropdown>().captionText.text;
		minute_string = minute1.GetComponent<Dropdown>().captionText.text;

		Int32.TryParse (hour_string, out hour_int);
		Int32.TryParse (minute_string, out minute_int);

		//if not selected, register for the clock, if selected, unregister it
		if (!selected) {
			//move to selected position
			b.GetComponent<RectTransform> ().localPosition = new Vector3 (237f, 343.3f, 0f);
			selected = true;

			//register alarm in unity "settings" script
			GameObject.Find("Main Camera").GetComponent<settings>().setHour(hour_int);
			GameObject.Find("Main Camera").GetComponent<settings>().setMinute(minute_int);

			//register for ios alarm
			Calarm.registerForAlarmCS (hour_int, minute_int);
		} else {
			//move to unselected position
			b.GetComponent<RectTransform> ().localPosition = new Vector3 (182f, 343.3f, 0f);
			selected = false;

			//unregister for ios alarm
			Calarm.unregisterForAlarmCS();
		}




	}

	void actionOnClick2(Button c)
	{   
		Debug.Log("Success click2");
		canvas0.SetActive(false);
		canvas.SetActive(true);

	}


}
