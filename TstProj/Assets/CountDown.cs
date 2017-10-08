using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour {

	public static IEnumerator DoCountDown(MonoBehaviour caller){

		for (int i = 3; i > 0; i--) {
			yield return caller.StartCoroutine (CountOnce (caller, i));
		}
		print ("GO!");
	}

	public static IEnumerator CountOnce(MonoBehaviour caller, int number){
		print (number);
		yield return new WaitForSeconds (1f);

	}
}
