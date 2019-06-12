using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkans : MonoBehaviour {

	public string ans="";
	public GameObject cards;
	public GameObject ansboard;
	public int currentquestion,words;
	public GameObject ldnxtlvl,sprinkles;
	public GameObject wrong;
	AudioSource source;
	public Animator animator;
	public puppetscript puppet;
	int lang;
	void Start()
	{
		lang = PlayerPrefs.GetInt ("lang", 1);
		source = gameObject.GetComponent<AudioSource>();
	}
	public void onMouseDown()
	{	
		source.Play ();
		ansboard.SetActive(true);
		Invoke("iscorrect",0.5f);		
	}
	void iscorrect()
	{
		ansscript[] anss = ansboard.GetComponentsInChildren<ansscript> ();
		string temp = "";
		for(int i=0;i<anss.Length;i++)
		{
			if(i==0)
				temp = "" + anss [i].unique_id;
			else
				temp += ":" + anss [i].unique_id;
		}
		ansboard.SetActive(false);
		//print (temp);
		int flag = 0;
		for (int i = 0; i < temp.Length; i++) {
			if (temp [i] != ans [i]) {
				flag = 1;
				break;
			}
		}
		if (flag == 1) {
			//not same
			puppet.laugh();
			print("Note same");
			wrong.SetActive (true);
			Invoke ("fadeout", 2f);
		} else {
			//same
			puppet.win();
			print("Same");
			sprinkles.SetActive (true);
			Invoke ("nextlevelbutton", 1f);
		}
	}
	void nextlevelbutton()
	{
		ldnxtlvl.SetActive (true);
	}
	public void loadnextlevel()
	{
		source.Play ();
		if (words == 2) {
			if (currentquestion < 50) {
				currentquestion += 1;
				PlayerPrefs.SetInt ("currentquestion2"+lang,currentquestion);
				animator.SetBool ("fadeout",false);
				Invoke ("loadlevelafterfade", 1f);
			} else {
				currentquestion += 1;
				PlayerPrefs.SetInt ("currentquestion2"+lang,currentquestion);
				PlayerPrefs.SetInt ("currentquestion3"+lang, 1); 
				PlayerPrefs.SetInt ("level", 2); // 3 words
				animator.SetBool ("fadeout",false);
				Invoke ("chooselevel", 1f);
			}
		} else {
			if (currentquestion < 50) {
				currentquestion += 1;
				PlayerPrefs.SetInt ("currentquestion3"+lang, currentquestion);
				animator.SetBool ("fadeout",false);
				Invoke ("loadlevelafterfade", 1f);
				//Application.LoadLevel (Application.loadedLevel);
			} else {
				currentquestion += 1;
				PlayerPrefs.SetInt ("currentquestion3"+lang,currentquestion);
				animator.SetBool ("fadeout",false);
				Invoke ("gamecompleted", 1f);
			}
		}
	}
	void chooselevel()
	{
		Application.LoadLevel("chooselevel");
	}
	void loadlevelafterfade()
	{
		Application.LoadLevel (Application.loadedLevel);
	}
	void gamecompleted()
	{
		Application.LoadLevel ("gamecompleted");
	}
	public void fadeout()
	{
		puppet.idle();
		wrong.SetActive (false);
	}
}
