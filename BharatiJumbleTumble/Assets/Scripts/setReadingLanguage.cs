using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setReadingLanguage : MonoBehaviour {

	//Hindi 1
	//Tamil 2
	//Telugu 3
	//Bengali 4
	//Malayalam 5
	public int lang = 1;
	void Start () {
		gameObject.GetComponent<Button>().onClick.AddListener(()=>SaveLanguage());
	}
	
	void SaveLanguage () {
		PlayerPrefs.SetInt ("rlang", lang);
	}
}
