using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnswerTile : MonoBehaviour, IPointerDownHandler {

	public void Start (){
		gameObject.layer = TileGameManager.clickCollider;
		var boxCol = gameObject.GetComponent<BoxCollider> ();
		if (boxCol == null)
			boxCol = gameObject.AddComponent<BoxCollider> ();
	}

	// Use this for initialization
	public void OnPointerDown(PointerEventData data){
		string sentence = "clicked " + transform.parent.name;
		print (sentence);
		TileGameManager.printString = sentence;
	}
}
