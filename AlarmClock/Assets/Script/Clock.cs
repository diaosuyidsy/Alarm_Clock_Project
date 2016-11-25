using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class Clock : MonoBehaviour {

	public int scoreThreshold;

	void Start()
	{

	}

	void Update()
	{
		if (GameObject.Find ("Canvas").GetComponent<Buttonlighter> ().getPlayerScore () == scoreThreshold) {
			GetComponent<AudioSource> ().Stop ();
			SceneManager.LoadScene ("AlarmClock_scene");
		}
	}
}
