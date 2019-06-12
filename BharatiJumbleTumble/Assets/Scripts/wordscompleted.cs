using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wordscompleted : MonoBehaviour {

	public int words;
	public Text text;
	void Start () {
		int language = PlayerPrefs.GetInt ("lang", 1);
		int v = PlayerPrefs.GetInt ("currentquestion"+words+""+language, 0);
		if (v != 0)
			v-=1;
		text.text = v+"/50";
	}
}
