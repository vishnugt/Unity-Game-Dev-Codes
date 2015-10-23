using UnityEngine;
using System.Collections;

public class time : MonoBehaviour {

	public static float time_elapsed=0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		time_elapsed += Time.deltaTime;
		GUI.Label(new Rect(0, 0, 200, 100), "time " + time_elapsed);
	}

}
