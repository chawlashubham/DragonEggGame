using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dragonmovement : MonoBehaviour {
//	public Animator anim;

	public int score;
	public Text ScoreText;
	public GameObject button;
	public GameObject scorecard;
	public GameObject eggcard;
	public GameObject nest;
	public GameObject egg;

	public Animator anim,anim2,anim3;
	public KeyCode moveup;
	public KeyCode shoot;
	public KeyCode movedown;
	public KeyCode moveright;
	public KeyCode moveleft;
	public int k;
// 	public AudioClip start;
	// private int flag; 
	private int y;
	// private int m;

	public void StartGame()
	{
	//	start = Resources.Load("sounds/start"),AudioClip);
		button.SetActive (false);
		gameObject.SetActive (true);
		egg.SetActive (true);
		eggcard.SetActive (true);
		nest.SetActive (true);
		scorecard.SetActive (true);


	}

	// Use this for initialization
	void Start () {
		score = 0;
	//	flag = 0;
		SetScoreText ();
		gameObject.SetActive (false);
		egg.SetActive (false);
		eggcard.SetActive (false);
		nest.SetActive (false);
		scorecard.SetActive (false);

		k = 0;

	}
	
	// Update is called once per frame
	void Update () {



		if (Input.GetKey (moveup))
		{
			anim.SetTrigger ("up");
			transform.Translate (Vector2.up * 5f * Time.deltaTime);
			k = 0;
		}
	
		if (Input.GetKey (shoot)) {
			//transform.eulerAngles = new Vector3 (0, 0, 40);
			if (k == 0) {
				//transform.eulerAngles = new Vector3 (0, 0, 40);
				anim2.SetTrigger ("burn");
				//transform.position = new Vector2 (12,2.01f);
				//transform.Translate (Vector2.right * 5f * Time.deltaTime);
				anim2.SetTrigger ("burn2");
				//	transform.position = new Vector2 (8,2.01f);
				//transform.Translate (Vector2.right * 5f * Time.deltaTime);
				anim2.SetTrigger ("burn3");
			}
			if (k == 1) {
				//transform.eulerAngles = new Vector3 (0, 0, 40);
				anim3.SetTrigger ("burn");
				//transform.position = new Vector2 (12,2.01f);
				//transform.Translate (Vector2.right * 5f * Time.deltaTime);
				anim3.SetTrigger ("burn2");
				//	transform.position = new Vector2 (8,2.01f);
				//transform.Translate (Vector2.right * 5f * Time.deltaTime);
				anim3.SetTrigger ("burn3");
			}
		}

		if (Input.GetKey (movedown))
		{
			anim.SetTrigger ("up");
			transform.Translate (Vector2.down * 5f * Time.deltaTime);
			k = 0;
		}

		if (Input.GetKey (moveright)) 
		{
			anim.SetTrigger ("right");
			transform.Translate (Vector2.right * 5f * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 0);
			k = 1;

		} 


		if (Input.GetKey (moveleft)) 
		{
			transform.Translate (Vector2.right * 5f * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 180);
			anim.SetTrigger ("right");
			k = 1;
		
		}




	}

	void OnCollisionEnter2D(Collision2D hit)
	{


		if (hit.gameObject.CompareTag ("vulture")) 

		{    
			  
		//	GameObject vulture = GameObject.Find("vulture");
		//	vulture_movement vulture_mov = vulture.GetComponent<vulture_movement>();
		//	y = vulture_mov.dead;
		//	Debug.Log (y);
			// if (y == 0)

				score += 10;
				SetScoreText ();
			//	 y = 1;


		}

		if (hit.gameObject.CompareTag ("side3") || hit.gameObject.CompareTag ("front"))
		{
			anim.SetInteger("hits",1);
		} 


	}

	void SetScoreText()
	{
		ScoreText.text = "Score: " + score.ToString ();

	}
}
