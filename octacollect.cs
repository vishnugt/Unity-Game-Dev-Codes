using UnityEngine;
using System.Collections;

public class octacollect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider collider)
	{
	 
	}


	void OnGUI()
	{
		GUI.Label(new Rect(0,0, 100,20), "coins");
	
	}
}
