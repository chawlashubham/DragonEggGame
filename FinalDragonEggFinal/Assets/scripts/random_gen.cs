using UnityEngine;
using System.Collections;

public class random_gen : MonoBehaviour {

	public GameObject[] vultures;
	public int amount;
	private Vector2 randpoint;

	
	// Update is called once per frame
	void Update () {
		vultures = GameObject.FindGameObjectsWithTag ("vulture");
		amount = vultures.Length;

		if(amount!=9)
		{
			InvokeRepeating ("spawnVulture",2,1.5f);




	
	}
}
	void spawnVulture()
	{
		randpoint.x = 25.19f;
	//	randpoint.z = 0;
		randpoint.y = Random.Range (1.01f,11.3f);
		Instantiate (vultures[UnityEngine.Random.Range(0,vultures.Length-1)],randpoint,Quaternion.identity);
		CancelInvoke ();
	
	}


}
		
