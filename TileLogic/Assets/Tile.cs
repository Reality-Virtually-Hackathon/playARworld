using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {
	//public string answer;

	public int tileNumber = -1;
	public bool correctAnswer = false;
	public int fontSize;

	public TextMesh textMesh;

	public void Generate(int setId, bool isCorrect, string setAnswer){
		//answer = setAnswer;
		textMesh.text = setAnswer;
		tileNumber = setId;
		correctAnswer = isCorrect;
		gameObject.SetActive (true);

	}

	//if it is correct we send manager to next otherwise we remove tile and check how many are left
	public void RemoveTile(){
		gameObject.SetActive (false);
	}

}
