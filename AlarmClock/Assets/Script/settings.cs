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
	public Button g_1;
	public Button g_2;
	public GameObject canvas;
	public GameObject canvas0;

	//book keeping
	private Button lastSelectedSpeedButton;
	private Button lastSelectedGameButton;


	private int HOUR;
	private int MINUTE;
	// Use this for initialization
	void Start () {

		a_3.GetComponent<Image> ().color = new Color32 (2, 231, 118, 255);
		lastSelectedSpeedButton = a_3;

		g_1.GetComponent<Image> ().color = new Color32 (2, 231, 118, 255);
		lastSelectedGameButton = g_1;
		
		b0.onClick.AddListener(() => actionOnClick0());

		a_1.onClick.AddListener(() => actionOnClick_speed(a_1, 1));

		a_2.onClick.AddListener(() => actionOnClick_speed(a_2, 2));

		a_3.onClick.AddListener(() => actionOnClick_speed(a_3, 3));

		a_4.onClick.AddListener(() => actionOnClick_speed(a_4, 4));

		a_5.onClick.AddListener(() => actionOnClick_speed(a_5, 5));

		g_1.onClick.AddListener(() => actionOnClick_G(g_1, 1));

		g_2.onClick.AddListener(() => actionOnClick_G(g_2, 2));
	}

	void actionOnClick0()
	{
		Debug.Log("Success click2");
		canvas0.SetActive(true);
		canvas.SetActive(false);

	}


	void actionOnClick_speed(Button b, int speedselected) { 
		speed = speedselected;

		if(!b.Equals(lastSelectedSpeedButton)){
			//set last slected button to white
			lastSelectedSpeedButton.GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);

			//set newly selected button to green
			b.GetComponent<Image> ().color = new Color32 (2, 231, 118, 255);

			//set newly selected button to lastslecetedbutton
			lastSelectedSpeedButton = b;
		}
	}
		
	void actionOnClick_G(Button b, int optionselected) { 
		option = optionselected;

		if(!b.Equals(lastSelectedGameButton)){
			//set last selected button to white
			lastSelectedGameButton.GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);

			//set newly selected button to green
			b.GetComponent<Image> ().color = new Color32 (2, 231, 118, 255);

			//set newly selected button to lastslecetedbutton
			lastSelectedGameButton = b;
		}
	}
		

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
