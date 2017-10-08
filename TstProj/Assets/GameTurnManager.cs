using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTurnManager : MonoBehaviour {

	public static QuestionManager tileSetPrefab;
	public QuestionManager tileSetPrefabSource;

	public int numberLevels = 6;
	public static bool win;
	public static bool loose;
	public static bool reset;
	public static int lastChosenTile = -1;

	public List<GameObject> tiles;

	public void Awake(){
		tileSetPrefab = tileSetPrefab;
	}

	void Start () {
		tiles = new List<GameObject> ();
	}

	public IEnumerator PlayGame(){
		yield return StartCoroutine(CountDown.DoCountDown(this));

		for (int i = 0; i < numberLevels; i++) {

			yield return StartCoroutine (GoPrompt());


		}

	}

	public IEnumerator GoPrompt(){

		yield return StartCoroutine (BringUpNextPrompt());

	
	}


	public IEnumerator BringUpNextPrompt(){

		yield return StartCoroutine (EndLastPrompt());

	}

	public IEnumerator EndLastPrompt(){

		if (win) {
			print ("win");
		} else if (loose) {
			print ("loose");
		} else if (reset) {
			yield return StartCoroutine (Reset());
		}


	}

	public IEnumerator Reset(){

		yield return true;

	}


}
