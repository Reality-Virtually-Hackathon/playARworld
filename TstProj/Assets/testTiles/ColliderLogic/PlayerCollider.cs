using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour {

	GameObject mainCam;
	BoxCollider col;
	GameObject playerColGo;


	public static float floorHeight = 0.0f;

	void Start () {
		mainCam = TileGameManager.headCam.gameObject;

		playerColGo = new GameObject ("PlayerCol");
        playerColGo.transform.localScale = new Vector3(0.2f, 15.2f, 0.2f); 
		playerColGo.AddComponent<BoxCollider> ();
        //playerLayer = LayerMask.NameToLayer ("Player");
        playerColGo.layer = TileGameManager.playerLayer;
	}
	


	// Update is called once per frame
	void Update () {
		var distance = mainCam.transform.position.y - floorHeight;
		playerColGo.transform.position = new Vector3 (mainCam.transform.position.x, distance * 0.5f, mainCam.transform.position.z);
		var newScale = new Vector3 (playerColGo.transform.localScale.x, distance+15f, playerColGo.transform.localScale.z);
		playerColGo.transform.localScale = newScale;
	}
}
