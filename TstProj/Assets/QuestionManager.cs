using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is added to tileSet
public class QuestionManager : MonoBehaviour {

	public List<Tile> tiles;

	public Question question;


	public void Generate(Question setQuestion){
		question = setQuestion;

		List<int> intList = new List<int> ();
		intList.Add (0);
		intList.Add (1);
		intList.Add (2);

		//randomize
		for (int i = 0; i < intList.Count; i++) {
			int temp = intList[i];
			int randomIndex = Random.Range(i, intList.Count);
			intList[i] = intList[randomIndex];
			intList[randomIndex] = temp;
		}

		for (int i = 0; i < tiles.Count; i++) {
		
			if (intList [i] == 0) {
				tiles [i].Generate (i, true, question.answer);
			} else if(intList [i] == 1) {
				tiles [i].Generate (i, false, question.wrongAnswer1);
			}else {
				tiles [i].Generate (i, false, question.wrongAnswer2);
			}

		}
	}


}
