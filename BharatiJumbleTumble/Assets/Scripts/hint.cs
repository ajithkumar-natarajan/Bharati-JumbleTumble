using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hint : MonoBehaviour {

	public GameObject hintobj,hintText;
	public Slider slider;
	AudioSource source;
	void Start () {
		source = gameObject.GetComponent<AudioSource> ();
		gameObject.GetComponent<Button> ().onClick.AddListener (()=>loadhint());
	}
	
	void loadhint () {
		source.Play ();
		slider.value = slider.value - 10;
		hintobj.SetActive (true);
		hintText.SetActive (true);
		Invoke ("fadeout", 2f);
	}

	void fadeout()
	{
		hintobj.SetActive (false);
		//hintText.SetActive (false);
	}
}
