using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseplay : MonoBehaviour {

	Button button;
	int flag=1;
	public Sprite pause,play;
	Image spriterenderer;
	public GameObject cover;
	AudioSource source;
	// Use this for initialization
	void Start () {
		source = gameObject.GetComponent<AudioSource> ();
		spriterenderer = gameObject.GetComponent<Image> ();
		button = gameObject.GetComponent<Button> () as Button;
		button.onClick.AddListener (()=>pauseplayop());
	}
	
	// Update is called once per frame
	void pauseplayop () {
		source.Play ();
		if (flag == 1) {
			//pause
			flag = 0;
			spriterenderer.sprite = play;
			cover.SetActive (true);
		} else {
			flag = 1;
			spriterenderer.sprite = pause;
			cover.SetActive (false);
		}
	}
}
