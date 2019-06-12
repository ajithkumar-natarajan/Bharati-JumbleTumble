using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlock : MonoBehaviour {

	public GameObject lockk,text;
	void Start () {
		int n = PlayerPrefs.GetInt ("level", 1);
		if (n == 2) {
			gameObject.GetComponent<gotoscene> ().enabled = true;
			text.SetActive (true);
			lockk.SetActive (false);
		} else {
			gameObject.GetComponent<gotoscene> ().enabled = false;
		}
	}
	

}
