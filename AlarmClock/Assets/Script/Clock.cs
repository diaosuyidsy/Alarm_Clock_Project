using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class Clock : MonoBehaviour {

	public int scoreThreshold;

	void Update()
	{
		if (GameObject.Find ("Canvas").GetComponent<Buttonlighter> ().getPlayerScore () == scoreThreshold) {
			GetComponent<AudioSource> ().Stop ();
			//set parameters to mark game is done
			Calarm.setGameDoneCS (true);
			//load the initial scene
			SceneManager.LoadScene ("AlarmClock_scene");
		}
	}
}
