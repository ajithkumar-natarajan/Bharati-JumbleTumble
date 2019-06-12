using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nextlevel : MonoBehaviour {

	public checkans chk;
	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Button> ().onClick.AddListener (() => chk.loadnextlevel ());
	}
}
