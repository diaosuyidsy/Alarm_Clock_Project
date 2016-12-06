using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class game2 : MonoBehaviour
{

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
	public int playerscore = 0;
	private long tmp;
	public Text score;
	private int loop = 1;

	private List<GameObject> result;
	private List<GameObject> copy;
	// Use this for initialization
	void Start()
	{
		result = new List<GameObject>();
		score.text = "Score:" + playerscore;
		buttons = new GameObject[9];
		buttons[0] = button1;
		buttons[1] = button2;
		buttons[2] = button3;
		buttons[3] = button4;
		buttons[4] = button5;
		buttons[5] = button6;
		buttons[6] = button7;
		buttons[7] = button8;
		buttons[8] = button9;
		tmp = 0;


		var rand = new System.Random();

		HashSet<int> check = new HashSet<int>();
		for (int i = 0; i < 5 ;i++)
		{
			int curValue = rand.Next(0, 9);
			while (check.Contains(curValue))
			{
				curValue = rand.Next(0, 9);
			}
			buttons[curValue].GetComponent<Stats>().setclickable(true);
			result.Add(buttons[curValue]);
			check.Add(curValue);
		}
		copy= new List<GameObject>(result);
		Debug.Log("hi ");


		    

			




	}

	// Update is called once per frame
	void Update()
	{
		tmp++;
		if (tmp == 60)
		{
			

			if (result.Count != 0)
			{
				GameObject g = result[0];
				result.Remove(g);
				//set button red
				//StartCoroutine(updateFlash(g));
				updateFlash(g);
				Debug.Log("update_finish");

			}


			if (result.Count == 0 && loop == 1)
			{
				loop++;

				copy[0].GetComponent<Stats>().setclickable(true);
				Button t = copy[0].GetComponent<Button>();
				t.onClick.AddListener(() => actionOnClick(copy[0]));
				Debug.Log("0 ");

				copy[1].GetComponent<Stats>().setclickable(true);
				t = copy[1].GetComponent<Button>();
				t.onClick.AddListener(() => actionOnClick(copy[1]));
				Debug.Log("1 ");

				copy[2].GetComponent<Stats>().setclickable(true);
				t = copy[2].GetComponent<Button>();
				t.onClick.AddListener(() => actionOnClick(copy[2]));

				Debug.Log("2 ");

				copy[3].GetComponent<Stats>().setclickable(true);
				t = copy[3].GetComponent<Button>();
				t.onClick.AddListener(() => actionOnClick(copy[3]));
				Debug.Log("3 ");

				copy[4].GetComponent<Stats>().setclickable(true);
				t = copy[4].GetComponent<Button>();
				t.onClick.AddListener(() => actionOnClick(copy[4]));
				Debug.Log("4 ");
			}

			tmp = 0;
		}
	}

	//IEnumerator updateFlash(GameObject g)
	void updateFlash(GameObject g)

	{
		




		Button b = g.GetComponent<Button>();

		ColorBlock cb = b.colors;
		cb.normalColor = Color.red;
		b.colors = cb;
		//yield return new WaitForSeconds(1.0f);
		Debug.Log("Turned red");

	}

	void actionOnClick(GameObject o)
	{
		if (o.GetComponent<Stats>().getclickable())
		{
			Debug.Log("Success click");
			playerscore++;
			score.text = "Score:" + playerscore;
			o.GetComponent<Stats>().setclickable(false);

			o.GetComponent<Image>().color = Color.white;
		}
	}

	public int getPlayerScore()
	{
		return playerscore;
	}
}
