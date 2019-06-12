using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resetgame : MonoBehaviour {
	void Start () {
		gameObject.GetComponent<Button> ().onClick.AddListener (()=>resetAllLevels());	
	}
	void resetAllLevels () {
		PlayerPrefs.SetInt ("currentquestion2", 1);
		PlayerPrefs.SetInt ("currentquestion3", 1);
		PlayerPrefs.SetInt ("level", 1);
		Application.LoadLevel ("chooselevel");
	}
}
