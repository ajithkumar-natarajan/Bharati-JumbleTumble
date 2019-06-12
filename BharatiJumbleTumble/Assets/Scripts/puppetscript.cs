using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puppetscript : MonoBehaviour {

	public Animator head,left,right;
	public AudioClip idlesound;
	public AudioClip[] winsound;
	public AudioClip[] laughsound;
	AudioSource audiosource;

	void Start()
	{
		audiosource = gameObject.GetComponent<AudioSource> () as AudioSource;
	}
	public void idle()
	{
		audiosource.clip = idlesound;
		audiosource.Play ();
		head.SetBool ("idle", true);
		left.SetBool ("idle", true);
		right.SetBool ("idle", true);
	}
	public void laugh()
	{
		audiosource.clip = laughsound[Random.Range(0,laughsound.Length)];
		audiosource.Play ();
		head.SetBool ("idle", false);
		left.SetBool ("idle", false);
		right.SetBool ("idle", false);
	}

	public void win()
	{
		audiosource.clip = winsound[Random.Range(0,winsound.Length)];
		audiosource.Play ();
		head.SetBool ("idle", false);
		left.SetBool ("idle", false);
		right.SetBool ("idle", false);
		Invoke ("idle", 2f);
	}
}
