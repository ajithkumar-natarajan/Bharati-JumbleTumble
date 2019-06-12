﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToFb : MonoBehaviour {

	AudioSource source;

	void Start () {
		source = gameObject.GetComponent<AudioSource> ();
		gameObject.GetComponent<Button>().onClick.AddListener(()=>OpenUrl());
	}
	
	void OpenUrl () {
		Application.OpenURL ("https://bit.ly/BharatiFB");
	}
}
