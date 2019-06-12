using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hindiglyph : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Text>().text = changeHindiGlyph(gameObject.GetComponent<Text>().text);
	}
	string changeHindiGlyph(string originalText)
	{
		string[] words = originalText.Split(new char[]{' '});
		for(int k = 0; k < words.Length; k++)
		{
			if(words[k].Contains("\u093f")) // check if the word contains "i" vowel
			{
				char[] arr = words[k].ToCharArray();
				for (int i = 0; i < arr.Length -1 ; i++)
				{
					if(arr[i] == '\u093f')
					{
						arr[i] = arr[i-1];
						arr[i-1] = '\u093f';
					}
				}
				words[k] = new string(arr);
			}
		}
		originalText = string.Join(" ", words);
		return originalText;
	}
}
