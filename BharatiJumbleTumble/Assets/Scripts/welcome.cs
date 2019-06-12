using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class welcome : MonoBehaviour {
	void Start () {
		Invoke ("menu", 3.5f);	
	}
	void menu () {
		Application.LoadLevel ("menu");
	}
}
