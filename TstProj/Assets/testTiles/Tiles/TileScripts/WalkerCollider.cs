using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkerCollider : MonoBehaviour {

    //private float timeHit = 0;
    private int dt = 0; 

	public void Start (){
		gameObject.layer = TileGameManager.walkerColLayer;
		var boxCol = gameObject.GetComponent<BoxCollider> ();
		if (boxCol == null)
			boxCol = gameObject.AddComponent<BoxCollider> ();
		boxCol.isTrigger = true;

		var rigBod = gameObject.GetComponent<Rigidbody> ();
		if (rigBod == null)
			rigBod = gameObject.AddComponent<Rigidbody> ();
		rigBod.isKinematic = true;

	}
    
    public void OnTriggerEnter(Collider col)
    {
        dt = 0; 
        //if (col.gameObject.layer == TileGameManager.playerLayer)
        //{
            //string sentence = "Hit " + transform.parent.name;
            //print(sentence);
            //TileGameManager.printString = sentence;
        //}
	}

    public void OnTriggerStay(Collider col)
    {
        if(col.gameObject.layer == TileGameManager.playerLayer)
            dt++;
        if (dt > 35)
        {
            string sentence = "Hit " + transform.parent.name;
            print(sentence);
            TileGameManager.printString = sentence;
        }
    }

    public void OnTriggerExit(Collider col)
    {
        dt = 0; 
    }
}
