using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 0;
    private Vector3 myTargetPosition;

	
	// Update is called once per frame
	void Update ()
    {
        Movement();
        DestroyLongRange();
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }

        
    }

    void Movement()
    {
        myTargetPosition = new Vector3(0, 0, 1 * speed);

        this.gameObject.transform.position += myTargetPosition;
    }

    void DestroyLongRange()
    {
        if (this.gameObject.transform.position.z >= 30)
        {
            Destroy(this.gameObject);
        }
    }
}
