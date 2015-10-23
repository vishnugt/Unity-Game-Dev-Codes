using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {
	public AudioClip coinsound;

	void OnTriggerEnter(Collider collider)
	{
		if(collider.tag == "coin")

			{
			AudioSource.PlayClipAtPoint(coinsound, Vector3.zero);
			Coincountdown.coin++;
			Destroy(collider.gameObject);
			}
	}
}
