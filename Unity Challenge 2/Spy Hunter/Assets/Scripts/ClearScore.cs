using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearScore : MonoBehaviour {


	void Awake () 
	{
		ScoreManager.myScore = 0;
	}
	

}
