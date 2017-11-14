using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking; 
using UnityStandardAssets.CrossPlatformInput; 

public class Player1 : NetworkBehaviour {

	private Vector3 moving; 

	// Update is called once per frame
	void Update () 
	{
		if (!isLocalPlayer) {
			return;
		} 
			moving.x = CrossPlatformInputManager.GetAxis ("Horizontal");
			moving.y = 0;
			moving.z = CrossPlatformInputManager.GetAxis ("Vertical");

			transform.Translate (moving); 

		
	}
	 public override void OnStartLocalPlayer ()
	{
		GetComponentInChildren<Camera>().enabled= true; 
	}
}
