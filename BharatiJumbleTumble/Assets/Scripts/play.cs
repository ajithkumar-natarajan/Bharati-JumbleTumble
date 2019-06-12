using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class play : MonoBehaviour {

	Button button;
	// Use this for initialization
	void Start () {
		button = gameObject.GetComponent<Button> () as Button;
		button.onClick.AddListener (()=>StartGame());
	} 
	
	void StartGame () {
		int questionnumber = PlayerPrefs.GetInt ("currentquestion", 1);
		if (questionnumber > 10) {
			Application.LoadLevel ("3place");
		} else {
			Application.LoadLevel ("2place");
		}
	}
}
