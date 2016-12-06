using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class Game2_s : MonoBehaviour
{

	public int scoreThreshold = 5;

	void Update()
	{
		if (GameObject.Find("Canvas").GetComponent<game2>().getPlayerScore() == scoreThreshold)
		{
			Debug.Log(GameObject.Find("Canvas").GetComponent<game2>().getPlayerScore());
			GetComponent<AudioSource>().Stop();
			//set parameters to mark game is done
			Calarm.setGameDoneCS(true);
			//load the initial scene
			SceneManager.LoadScene("AlarmClock_scene");
		}
		else {
			SceneManager.LoadScene("game2");
		}
	}
}
