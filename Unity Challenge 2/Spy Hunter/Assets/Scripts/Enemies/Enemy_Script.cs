using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Script : MonoBehaviour {

    public int thisTargetScoreValue;

	// Update is called once per frame
	void Score ()
    {

        ScoreManager.myScore += thisTargetScoreValue; 		
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "PlayerProjectile")
        {
            Score();
            Destroy(this.gameObject);
        }
        
    }
}
