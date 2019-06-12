using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp : MonoBehaviour {

	public string filePath;
	string result="";
	// Use this for initialization
	void Start () {
		#if UNITY_EDITOR
		filePath = Application.dataPath + "/StreamingAssets/New.csv";
		result = System.IO.File.ReadAllText(filePath);
		string[] questionlist = result.Split (new string[]{ "\n" }, System.StringSplitOptions.None);

		for(int i=1;i<52;i++)
		{
			string[] list = questionlist[i].Split (new string[]{ "," }, System.StringSplitOptions.None);
			string[] gen = list [2].Split (new string[]{ ":" }, System.StringSplitOptions.None);

			for(int j=0;j<6;j++)
				if(gen[j].Length==0)
					print(i);
		}
		#endif
	}
}
