using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class settings : MonoBehaviour {

	public int speed = 3;
	public int option = 1;
	public Button b0;
	public Button a_1;
	public Button a_2;
	public Button a_3;
	public Button a_4;
	public Button a_5;
	public Button a_6;
	public Button a_7;
	public GameObject canvas;
	public GameObject canvas0;

	private int HOUR;
	private int MINUTE;
	// Use this for initialization
	void Start () {
		
		b0.onClick.AddListener(() => actionOnClick0());

		a_1.onClick.AddListener(() => actionOnClick1());

		a_2.onClick.AddListener(() => actionOnClick2());

		a_3.onClick.AddListener(() => actionOnClick3());

		a_4.onClick.AddListener(() => actionOnClick4());

		a_5.onClick.AddListener(() => actionOnClick5());

		a_6.onClick.AddListener(() => actionOnClick6());

		a_7.onClick.AddListener(() => actionOnClick7());
	}

	void actionOnClick0()
	{
		Debug.Log("Success click2");
		canvas0.SetActive(true);
		canvas.SetActive(false);

	}


	void actionOnClick1() { 
	speed = 1;
	}
	void actionOnClick2() { 
	speed = 2;}
	void actionOnClick3() { 
	speed = 3;}
	void actionOnClick4() {
	speed = 4;}
	void actionOnClick5() {
	speed = 5;}
	void actionOnClick6() { 
	option = 1;}
	void actionOnClick7() { 
	option = 2;}

	public void setHour(int hour)
	{
		HOUR = hour;
	}

	public void setMinute(int minute)
	{
		MINUTE = minute;
	}

	public int getHour()
	{
		return HOUR;
	}

	public int getMinute()
	{
		return MINUTE;
	}

	public void loadGameScene(string message)
	{
		if (option == 1) {
			SceneManager.LoadScene ("Login");
		} else {
			SceneManager.LoadScene ("game2");
		}


	}
}
