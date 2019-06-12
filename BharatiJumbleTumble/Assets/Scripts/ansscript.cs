using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ansscript : MonoBehaviour {


	public int unique_id=0;
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D collider)
	{
		//print("Collider");
		unique_id = collider.GetComponent<cardscript> ().unique_id;
	}
}
