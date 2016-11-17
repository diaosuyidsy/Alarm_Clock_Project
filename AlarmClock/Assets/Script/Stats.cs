using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {

	private bool clickable;

	// Use this for initialization
	void Start () {
		clickable = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setclickable(bool statement)
	{
		clickable = statement;
	}

	public bool getclickable()
	{
		return clickable;
	}
}
