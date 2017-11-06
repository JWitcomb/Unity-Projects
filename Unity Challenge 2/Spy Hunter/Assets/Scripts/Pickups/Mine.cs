using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mine : MonoBehaviour {

	public int damage = 100;
	private bool isClaimed = false;
	public int rotateSpeed = 1;
	public GameObject mine;

	void Update () 
	{
		float mineRotation = rotateSpeed * Time.deltaTime;
		mine.transform.Rotate (Vector3.up * mineRotation);
	}

	void OnTriggerEnter(Collider other)
	{
		if (isClaimed == false) 
		{
			if (other.gameObject.tag == "Player") 
			{
				PlayerHealth.PlayerHealthValue -= damage;
				isClaimed = true;
				Destroy(this.gameObject);
			}
		}

	}
}
