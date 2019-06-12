using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class currentlang : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int lang = PlayerPrefs.GetInt ("lang", 1);
		string temp = "Language";
		if(lang==1)
			temp = "Hindi";
		else if(lang==2)
			temp = "Tamil";
		else if(lang==3)
			temp = "Telugu";
		else if(lang==4)
			temp = "Bengali";
		else if(lang==5)
			temp = "Malayalam";

		gameObject.GetComponent<Text> ().text = "Language : "+temp;
	}
}
