﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking; 

public class MyHUD : NetworkManager 
{
	
	public void MyStartHost()
	{
		Debug.Log (Time.timeSinceLevelLoad + " Starting host " ); 
		StartHost ();
	}

	public override void OnStartHost ()
	{
		Debug.Log (Time.timeSinceLevelLoad + " Host started "); 
	}
	public override void OnStartClient(NetworkClient myClient)
	{
		Debug.Log ("Client start requested"); 
		InvokeRepeating ("PrintDot", 0f, 1f);
			
	}
	public override void OnClientConnect ( NetworkConnection conn)
	{
		Debug.Log (Time.timeSinceLevelLoad + " Client is connect to IP: "+ conn.address); 
		CancelInvoke ();
	}
	void PrintDot ()
	{
		Debug.Log (".");
	}
}
