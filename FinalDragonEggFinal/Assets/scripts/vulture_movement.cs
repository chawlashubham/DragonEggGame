using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class vulture_movement : MonoBehaviour {


	private int flag;
	private float moveSpeed=1.9f;
	public Transform track;
	 public int dead;
	private int m;
  //	public int call;

	// GameObject myGameObject = new GameObject("vulture"); // Make a new GO.


//	public Transform target;


	public void StartGame()
	{
		gameObject.SetActive (true);

	}


	// Use this for initialization
	void Start () {

	//	check = 0;
		flag = 0;
		dead = 0;
	

	}
	
	// Update is called once per frame
	void Update () {
		if (flag == 0) {
			transform.Translate (0.1f, 0, 0);
		} 
		else {
			  transform.Translate (0, 0, 0);
		}

		float move = moveSpeed * Time.deltaTime;
		transform.position = Vector2.MoveTowards(transform.position, track.position, move);

		GameObject nest = GameObject.Find("nest");
		score_card ch = nest.GetComponent<score_card>();
		m = ch.count;

		if (m == 0) {
			gameObject.SetActive (false);
		}


		 // transform.LookAt(target);
		// transform.eulerAngles = new Vector3 ( transform.eulerAngles.x,transform.eulerAngles.y ,0);

	}



	void OnCollisionEnter2D(Collision2D hit)
	{


		if (hit.gameObject.CompareTag ("player")) {
			//	anime.SetTrigger ("dead");
			//   transform.Rotate (0,0,90);
			//  anime.SetTrigger ("dead");
			//  dead = 1;
			gameObject.SetActive (false);
			//Debug.Log (dead);
		   	  flag = 1;
		//	  call = 1;
			 
			//	transform.eulerAngles = new Vector2 (0, 180);
			//	rb.useGravity=false;



			// transform.Rotate (180,0,0);

		}
		if (hit.gameObject.CompareTag ("back_wall")||hit.gameObject.CompareTag ("side1")||hit.gameObject.CompareTag ("front")) 
		{
	
			if(dead==1)
			{ 
				gameObject.SetActive (false);	
			}
			 
				transform.Rotate (0, 180, 0);

		}

		if (hit.gameObject.CompareTag ("side3")) 
		{
			gameObject.SetActive (false);
		}
		if (hit.gameObject.CompareTag ("nest")) 
		{    
			if (flag == 1) {
				gameObject.SetActive (false);
			}
			transform.Rotate (0, 180, 0);
		}



	
	}









}
