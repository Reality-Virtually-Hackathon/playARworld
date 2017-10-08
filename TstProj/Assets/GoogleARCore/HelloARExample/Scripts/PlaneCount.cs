using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoogleARCore.HelloAR
{
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Rendering;
    using GoogleARCore;

    public class PlaneCount : MonoBehaviour
    {
        private List<TrackedPlane> m_allPlanes = new List<TrackedPlane>();


        public void Update()
        {
            int count = 0;

            Frame.GetAllPlanes(ref m_allPlanes);
            for (int i = 0; i < m_allPlanes.Count; i++)
            {
                if (m_allPlanes[i].IsValid)
                {
                    count++;
                }
            }
            GUI.Label(new Rect(90, 510, 600, 300), new GUIContent(count.ToString()));
        }

    }
}