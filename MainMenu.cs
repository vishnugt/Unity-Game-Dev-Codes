using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		if(GUI.Button(new Rect(Screen.width/2, Screen.height/3, 150, 50),  "Coin collected "))
		{
			Application.LoadLevel(1);
		}

		if(GUI.Button(new Rect(Screen.width/2+80, Screen.height/3+90, 150+90, 50+20),  "Quit "))
		{
			Application.Quit();
		}

	}
}
