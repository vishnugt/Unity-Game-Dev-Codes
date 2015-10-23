using UnityEngine;
using System.Collections;

public class createdynamic : MonoBehaviour {


	public GameObject go = null;

	// Use this for initialization
	void Start () {
	
	Instantiate(go, Vector3.zero, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
