using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exit : MonoBehaviour {

	Button button;
	public Button yes,no;
	public GameObject exitmenu;
	AudioSource source;
	int flag=0;
	// Use this for initialization
	void Start () {
		source = gameObject.GetComponent<AudioSource> ();
		button = gameObject.GetComponent<Button> () as Button;
		button.onClick.AddListener (() => SetActiveExitMenu ());
		yes.onClick.AddListener (() => YesObj ());
		no.onClick.AddListener (() => SetActiveExitMenu ());
	}
	void SetActiveExitMenu () {
		source.Play ();
		if (flag == 0) {
			flag = 1;
			exitmenu.SetActive (true);
		} else {
			flag = 0;
			exitmenu.SetActive (false);
		}
	}
	void YesObj()
	{
		Application.Quit ();
	}
}