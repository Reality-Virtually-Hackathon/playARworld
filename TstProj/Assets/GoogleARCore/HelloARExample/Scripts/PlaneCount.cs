using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCount : MonoBehaviour {

    public void OnGUI()
    {
        int count = 0;

        if (GUI.Button(new Rect(90, 210, 600, 300), new GUIContent("count"))) {
            var planes = Object.FindObjectsOfType(typeof(GoogleARCore.TrackedPlane));
            count = planes.Length;
        }
        
    }
}
