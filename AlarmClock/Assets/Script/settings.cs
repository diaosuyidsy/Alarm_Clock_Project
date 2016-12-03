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
	// Use this for initialization
	void Start () {
		
		Button b = b0.GetComponent<Button>();
		b.onClick.AddListener(() => actionOnClick0(b));

		Button a1 = a_1.GetComponent<Button>();
		b.onClick.AddListener(() => actionOnClick1(a1));

		Button a2 = a_2.GetComponent<Button>();
		b.onClick.AddListener(() => actionOnClick2(a2));

		Button a3 = a_3.GetComponent<Button>();
		b.onClick.AddListener(() => actionOnClick3(a3));

		Button a4 = a_4.GetComponent<Button>();
		b.onClick.AddListener(() => actionOnClick4(a4));

		Button a5 = a_5.GetComponent<Button>();
		b.onClick.AddListener(() => actionOnClick5(a5));

		Button a6 = a_6.GetComponent<Button>();
		b.onClick.AddListener(() => actionOnClick6(a6));

		Button a7 = a_7.GetComponent<Button>();
		b.onClick.AddListener(() => actionOnClick7(a7));
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void actionOnClick0(Button c)
	{
		Debug.Log("Success click2");
		canvas0.SetActive(true);
		canvas.SetActive(false);

	}


	void actionOnClick1(Button c) { 
	speed = 1;
	}
	void actionOnClick2(Button c) { 
	speed = 2;}
	void actionOnClick3(Button c) { 
	speed = 3;}
	void actionOnClick4(Button c) {
	speed = 4;}
	void actionOnClick5(Button c) {
	speed = 5;}
	void actionOnClick6(Button c) { 
	option = 1;}
	void actionOnClick7(Button c) { 
	option = 2;}
}
