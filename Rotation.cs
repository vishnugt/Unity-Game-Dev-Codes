using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	public int somevalue = 30;

	void Start () {
	
	}
	
	void Update () {
	transform.Rotate(somevalue*Time.deltaTime, 0, 0);
	}
}
