using UnityEngine;
using UnityEngine.UI;
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
	private int playerscore = 0;
	private long tmp;

	public Text score;

	// Use this for initialization
	void Start () {
		score.text = "Score:" + playerscore;
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
			StartCoroutine(updateFlash());

			tmp = 0;
		}
	}

	IEnumerator updateFlash(){
		int number = Random.Range(0, 8);
		buttons [number].GetComponent<Stats> ().setclickable (true);


		Button b = buttons[number].GetComponent<Button>();
		b.onClick.AddListener(() => actionOnClick (buttons [number]));
		ColorBlock cb = b.colors;
		cb.normalColor = Color.red;
		b.colors = cb;
		yield return new WaitForSeconds (2.0f);
		cb.normalColor = Color.white;
		b.colors = cb;
		buttons [number].GetComponent<Stats> ().setclickable (false);
	}

	void actionOnClick(GameObject o){
		if(o.GetComponent<Stats> ().getclickable())
		{
			Debug.Log ("Success click");
			playerscore++;
			score.text = "Score:" + playerscore;
			o.GetComponent<Stats> ().setclickable (false);
		}
	}
}
