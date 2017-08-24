using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 0;
    private Vector3 myTargetPosition;

	
	// Update is called once per frame
	void Update ()
    {
        myTargetPosition = new Vector3(0, 0, 1 * speed);

        this.gameObject.transform.position += myTargetPosition;
	}
}
