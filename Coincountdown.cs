using UnityEngine;
using System.Collections;

public class Coincountdown : MonoBehaviour {

public static int coin = 0;
public static int time = 0 ;


void OnGUI()
{
	int someflag=1;
	int time2=0;

	GUI.Label(new Rect(10, 10, 100, 20),  "Coin collected " + coin);

	if(coin==7)
	{
		someflag=0;
		time2 = (int)Time.time;
	
	}
	
	int timet = (int)Time.time ;


	if(someflag==1)
	{
		GUI.Label(new Rect(10, 20, 100, 40), "Time is " + timet);
	}


	else 
	GUI.Label(new Rect(10, 20, 100, 40), "Time is " + time2);

}

}
