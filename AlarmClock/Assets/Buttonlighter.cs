﻿using UnityEngine;
using System.Collections;

public class Buttonlighter : MonoBehaviour {

	public GameObject button1;
	public GameObject button2;
	public GameObject button3;
	public GameObject button4;
	public GameObject button5;
	public GameObject button6;
	public GameObject button7;
	public GameObject button8;
	public GameObject button9;
	private GameObject[] buttons;
	private int counter = 20;
	private long tmp;

	public GameObject score;

	// Use this for initialization
	void Start () {
		buttons = new GameObject[9];
		buttons [0] = button1;
		buttons [1] = button2;
		buttons [2] = button3;
		buttons [3] = button4;
		buttons [4] = button5;
		buttons [5] = button6;
		buttons [6] = button7;
		buttons [7] = button8;
		buttons [8] = button9;
		tmp = 0;
		// todo
	}
	
	// Update is called once per frame
	void Update () {
		tmp++;
		if (tmp == 60) {
			//set button red
			int number = Random.Range(0, 8);
			buttons [number].GetComponent<Button> () = Color.red;

			tmp = 0;
		}
	}
}