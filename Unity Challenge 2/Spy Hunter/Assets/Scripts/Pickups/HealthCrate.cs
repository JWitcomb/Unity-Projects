using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCrate : MonoBehaviour {

	public int healthReclaimed = 20;
	private bool isClaimed = false;

	void Update () 
	{

	}

	void OnTriggerEnter(Collider other)
	{
		if (isClaimed == false) 
		{
			PlayerHealth.PlayerHealthValue += healthReclaimed;

			if (PlayerHealth.PlayerHealthValue >= 100) 
			{
				PlayerHealth.PlayerHealthValue = 100;
				isClaimed = true;
				Destroy (this.gameObject);
			} 

			else 
			
			{
				isClaimed = true;
				Destroy(this.gameObject);
			}
		}
	}
}
