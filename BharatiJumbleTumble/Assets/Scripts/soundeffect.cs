using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundeffect : MonoBehaviour {

	public AudioSource audiosource;
	void Start () {
		audiosource = gameObject.GetComponent<AudioSource> ();
		Invoke ("sound", 1.6f);
	}

	void sound()
	{
		audiosource.Play();
	}

}
