using UnityEngine;
using UnityEditor;

public class QuestionAsset {

	public class YourClassAsset
	{
		[MenuItem("Assets/Create/Question")]
		public static void CreateAsset ()
		{
			ScriptableObjectUtility.CreateAsset<Question> ();
		}
	}
}
