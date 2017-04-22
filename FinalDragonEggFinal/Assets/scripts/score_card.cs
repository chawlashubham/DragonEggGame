using UnityEngine;
using UnityEngine.UI;
using System.Collections;

   


public class score_card : MonoBehaviour {

	public int count;
	public Text EggCount;
	public Text WinText;
	private int check;
	public GameObject egg1;
	public GameObject egg2;
	public GameObject egg3;
	public GameObject egg4;
	public GameObject egg5;
	private int x;
	private int y;

	// Use this for initialization
	void Start () {

		count = 5;
		check=0;
		SetEggCount ();
		WinText.text = "";

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D hit)
	{
		if (hit.gameObject.CompareTag ("vulture"))
		{
			GameObject vulture = GameObject.Find("vulture");
			vulture_movement vulture_mov = vulture.GetComponent<vulture_movement>();
			y = vulture_mov.dead;

			if (count > 0 && y==0) {
				//	hit.gameObject.SetActive (false);
				count--;
			//	i++;
				// transform.Rotate (0,180, 0);
				//	anime.SetTrigger ("attack");
				SetEggCount ();
				check++;
			}
		}

		if (check == 1) 
		{
			egg1.gameObject.SetActive (false);
		}

		if (check == 2) 
		{
			egg2.gameObject.SetActive (false);
		}

		if (check == 3) 
		{
			egg3.gameObject.SetActive (false);
		}

		if (check == 4) 
		{
			egg4.gameObject.SetActive (false);
		}

		if (check == 5) 
		{
			egg5.gameObject.SetActive (false);
		}


}
	void SetEggCount()
	{
		EggCount.text = "Eggs: " + count.ToString ();
		if (count == 0) {

			GameObject dragon = GameObject.Find("flyingto right dragon");
			dragonmovement player_mov = dragon.GetComponent<dragonmovement>();
			x=player_mov.score;
			WinText.text = "   Game Over!\nYour Score Is: "+ x.ToString();
			//	WinText.text = "Game Over!\nYour Score Is:";
			player_mov.gameObject.SetActive(false);
		//	DelayedAttribute (1000);
		}

	}

}
