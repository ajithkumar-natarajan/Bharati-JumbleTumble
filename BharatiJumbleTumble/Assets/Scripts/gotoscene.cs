using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gotoscene : MonoBehaviour {

	public string scenename;
	AudioSource source;
	public Animator animator;
	// Use this for initialization
	void Start () {
		source = gameObject.GetComponent<AudioSource> ();
		gameObject.GetComponent<Button>().onClick.AddListener(()=>openscene());
	}
	
	// Update is called once per frame
	public void openscene () {
		source.Play ();
		animator.SetBool ("fadeout",false);
		Invoke ("loadlevel", 1f);
	//	Invoke ("loadlevel", 0.1f);
	}

	void loadlevel()
	{
		Application.LoadLevel (scenename);
	}
}
