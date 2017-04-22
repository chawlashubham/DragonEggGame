using UnityEngine;
using System.Collections;

public class fireburning : MonoBehaviour {
	public Animator anim;
	public KeyCode shoot;
	public int ch;


	// Use this for initialization
	void Start () {
		ch = 2;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (shoot))
		{
			if (ch == 2) {
				transform.eulerAngles = new Vector3 (0, 0, 40);
			}
			ch = 3;
			anim.SetTrigger ("burn");
			//transform.position = new Vector2 (12,2.01f);
			//transform.Translate (Vector2.right * 5f * Time.deltaTime);
			anim.SetTrigger ("burn2");
		//	transform.position = new Vector2 (8,2.01f);
			//transform.Translate (Vector2.right * 5f * Time.deltaTime);
			anim.SetTrigger ("burn3");
		//	transform.position = new Vector2 (12,2.01f);
			//transform.Translate (Vector2.right * 5f * Time.deltaTime);
		}
	
	}
}
