using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	Slider slider;
	public GameObject tryagain;
	public pauseplay pply;
	public checkans chkans;
	void Start () {
		slider = gameObject.GetComponent<Slider> () as Slider;
		Invoke ("timerloop", 1.2f);
	}
	
	void timerloop () {
		if (slider.value == 0) {
			tryagain.SetActive (true);
		} else {
			if (!pply.cover.activeInHierarchy && !chkans.ldnxtlvl.activeInHierarchy) {
				slider.value = slider.value - 1;
			}
			Invoke ("timerloop", 1.2f);
		}
	}
}
