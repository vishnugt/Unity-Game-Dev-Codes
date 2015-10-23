using UnityEngine;
using System.Collections;

public class disappear : MonoBehaviour {

	static int coins_collected = 0;

	void OnTriggerEnter(Collider collider)
	{
		if(collider.tag == "coin")

			{
			Destroy(collider.gameObject);
			coins_collected++;
			}
	}

	void OnGUI()
	{
		GUI.Label(new Rect(10, 10, 100, 20),  "Coin collected " + coins_collected);
	}
}
