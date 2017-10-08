using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TileGameManager : MonoBehaviour {
	public static int playerLayer;
	public static int walkerColLayer;
	public static int clickCollider;

	public bool doPrintHits = false;
	private GUIStyle style;
	private Rect rectShow;
	public static string printString = "";

    public Camera headCamSource;
	public static Camera headCam;
	// Use this for initialization
	void Awake(){
        headCam = headCamSource;

		playerLayer = LayerMask.NameToLayer ("Player");
		walkerColLayer = LayerMask.NameToLayer ("WalkCollider");
		clickCollider = LayerMask.NameToLayer ("ClickCollider");

		if (playerLayer == -1 || playerLayer == -1 || playerLayer == -1)
			Debug.LogError ("Make sure there is a Player, WalkCollider and ClickCollider Layer");
	}

	void Start () {

		//mainCam = Camera.main;
		var caster = headCam.gameObject.AddComponent<PhysicsRaycaster> ();
		caster.eventMask = 1 << clickCollider;

		//gameObject.AddComponent<EventSystem> ();
		//gameObject.AddComponent<StandaloneInputModule> ();
		gameObject.AddComponent<PlayerCollider> ();

		style = new GUIStyle ();

		#if UNITY_EDITOR
		rectShow = new Rect (30, 100, 100, 200);
		//style.fontSize = 1;
		#else
		rectShow = new Rect (30, 500, 300, 300);
		style.fontSize = 100;
		#endif

	}

	public void OnGUI(){
		if (doPrintHits) {


			GUI.Label (rectShow, new GUIContent (printString), style);
		}
	}
}
