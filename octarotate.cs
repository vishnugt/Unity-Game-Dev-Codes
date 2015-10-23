using UnityEngine;
using System.Collections;

public class octarotate : MonoBehaviour {

	public int rotate_value;
	void Start () {
	
	}
	
	void Update () {
	transform.Rotate(0,0,rotate_value*Time.deltaTime);
	}
}
