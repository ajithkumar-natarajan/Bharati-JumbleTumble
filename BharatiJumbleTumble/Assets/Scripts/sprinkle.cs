using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprinkle : MonoBehaviour {

	public GameObject sprinkleobject,ladoo;
	void Start () {
		Invoke ("fadeout", 1f);
	}
	
	void fadeout () {
		sprinkleobject.SetActive (true);
		ladoo.SetActive (false);
	}
}
