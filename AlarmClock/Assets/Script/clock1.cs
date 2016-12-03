using UnityEngine;
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
	private int count = 0;

	private String hour_string;
	private String minute_string;

	void Start()
	{
		timeNow = DateTime.Now;
		audio1 = GetComponent<AudioSource>();

		Button b = b1.GetComponent<Button>();
		b.onClick.AddListener(() => actionOnClick(b));

		Button c = b2.GetComponent<Button>();
		c.onClick.AddListener(() => actionOnClick2(c));


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
		audio1.Play();
		Debug.Log("actually rings");
		audio1.Play(44100);
		SceneManager.LoadScene("Login");

	}


	void actionOnClick(Button b)
	{
		Debug.Log("Success click");

		hour_string = hour1.GetComponent<Dropdown>().captionText.text;
		minute_string = minute1.GetComponent<Dropdown>().captionText.text;


	}

	void actionOnClick2(Button c)
	{   
		Debug.Log("Success click2");
		canvas0.SetActive(false);
		canvas.SetActive(true);

	}


}
