using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	public int somevalue = 100;

	void Start () {
	
	}
	

	void Update () {
		transform.Rotate(0, 0, somevalue* Time.deltaTime);
		transform.Translate(0, 0, 0);



	
	}
}
