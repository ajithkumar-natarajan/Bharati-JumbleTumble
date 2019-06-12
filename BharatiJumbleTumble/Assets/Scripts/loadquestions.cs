using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using UnityEngine.UI;

public class loadquestions : MonoBehaviour {

	public string filePath;
	string result="";
	public cardscript[] cardscrpt,anscardscrpt;
	//public int cards=2;
	public int smallcard=0,center=4;
	public checkans checkn;
	int questionnumber=1,language=1;
	public int type=2;
	public Text hintText;

	public GameObject bharati;

	public Sprite[,] bharatians = new Sprite[5,10];

	public Sprite[] hindi = new Sprite[10];
	public Sprite[] tamil = new Sprite[10];
	public Sprite[] telugu = new Sprite[10];
	public Sprite[] bengali = new Sprite[10];
	public Sprite[] malayalam = new Sprite[10];

	UnicodeToKrutidev unidkruti;

	void Start () {
		unidkruti = new UnicodeToKrutidev ();
		language = PlayerPrefs.GetInt ("lang", 1);

		//PlayerPrefs.SetInt ("currentquestion2"+language, 1);

		if(type==2)
			questionnumber = PlayerPrefs.GetInt ("currentquestion2"+language, 1); //Random.Range(1,90);
		else 
			questionnumber =  PlayerPrefs.GetInt ("currentquestion3"+language, 1); //Random.Range(1,50);

		print (type+" "+questionnumber);

		for(int ii=0;ii<10;ii++)
			bharatians[0,ii] = hindi[ii];
		for(int ii=0;ii<10;ii++)
			bharatians[1,ii] = tamil[ii];
		for(int ii=0;ii<10;ii++)
			bharatians[2,ii] = telugu[ii];
		for(int ii=0;ii<10;ii++)
			bharatians[3,ii] = bengali[ii];
		for(int ii=0;ii<10;ii++)
			bharatians[4,ii] = malayalam[ii];

		#if UNITY_EDITOR
		if(type==2){
			filePath = Application.dataPath + "/StreamingAssets/Questions/2letters/"+language+"lang.csv";
		}
		else{
			filePath = Application.dataPath + "/StreamingAssets/Questions/3letters/"+language+"lang.csv";
		}
		result = System.IO.File.ReadAllText(filePath);
		//print(result);
		#elif UNITY_ANDROID
		if(type==2)
			filePath = "jar:file://" + Application.dataPath + "!/assets/Questions/2letters/"+language+"lang.csv";
		else
			filePath = "jar:file://" + Application.dataPath + "!/assets/Questions/3letters/"+language+"lang.csv";
		WWW loadDB = new WWW(filePath);
		while(!loadDB.isDone){}
		File.WriteAllBytes(Application.persistentDataPath + "/random.csv", loadDB.bytes);
		result = File.ReadAllText(Application.persistentDataPath + "/random.csv");
		#endif
		string[] questionlist = result.Split (new string[]{ "\n" }, System.StringSplitOptions.None);
		//print (questionlist [questionnumber]);
		loadscene (questionlist[questionnumber]);
	}

	void loadscene(string ques)
	{
		string[] list = ques.Split (new string[]{ "," }, System.StringSplitOptions.None);
		//print (list [2]);
		string[] subsprite = list [2].Split (new string[]{ ":" }, System.StringSplitOptions.None);
		string[] mainans = subsprite;
		hintText.text = UnicodeToKrutidev.UnicodeToKrutiDev(list [0]);

		print (list [2]);

		if (questionnumber < 11)
			bharati.GetComponent<Image> ().sprite = bharatians [language - 1, questionnumber - 1];
		else
			bharati.SetActive (false);

		for (int i = 0; i < anscardscrpt.Length; i++) {
			//print (subsprite [i]);
			int value = int.Parse (subsprite [i]);
			//print (value+" "+i);
			anscardscrpt [i].unique_id = value;
			anscardscrpt [i].UpdateSubsprite ();
		}

		checkn.ans = list [2];
		checkn.currentquestion = questionnumber;
		checkn.words = type;
		//Random rand = new Random();

		for (int i = 0; i < subsprite.Length; i++) {
			int index = Random.Range(i, subsprite.Length-1);
			string temp = subsprite [index];
			subsprite [index] = subsprite [i];
			subsprite [i] = temp;
		}

		for (int i = 0; i < cardscrpt.Length; i++) {
			int value = int.Parse (subsprite [i]);
			if (value >= 5 && value <= 21) {
				cardscrpt [center].unique_id = value;
				cardscrpt [center++].UpdateSubsprite ();
			}
			else {
				cardscrpt [smallcard].unique_id = value;
				cardscrpt [smallcard++].UpdateSubsprite ();
			}
		}
	}
}
