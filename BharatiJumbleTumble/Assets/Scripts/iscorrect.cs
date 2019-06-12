using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class iscorrect : MonoBehaviour {
	Button button;
	public checkans chkans;
	void Start () {
		button = gameObject.GetComponent<Button> () as Button;
		button.onClick.AddListener(()=>check());
	}

	void check()
	{
		//print ("click");
		chkans.onMouseDown ();
	}
}
