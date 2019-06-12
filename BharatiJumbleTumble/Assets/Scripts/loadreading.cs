using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadreading : MonoBehaviour {

	public Sprite[] sprites = new Sprite[5];
	public GameObject spriteobj;
	// Use this for initialization
	void Start () {
		spriteobj.GetComponent<Image> ().sprite = sprites [PlayerPrefs.GetInt ("rlang", 1)-1];
		print (PlayerPrefs.GetInt ("rlang", 1));
	}
}
