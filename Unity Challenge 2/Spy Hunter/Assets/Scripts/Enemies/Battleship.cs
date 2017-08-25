using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battleship : MonoBehaviour {

    public GameObject battleshipPrefab;

    public GameObject waypoint1;
    public GameObject waypoint2;
    public GameObject waypoint3;
    public GameObject waypoint4;

    private Vector3 waypoint1Position;
    private Vector3 waypoint2Position;
    private Vector3 waypoint3Position;
    private Vector3 waypoint4Position;

    private Vector3 battleshipCurrentPosition;

    public float speed;



	
	// Update is called once per frame
	void Update ()
    {
        TargetPositions ();
        battleshipPrefab.transform.position = Vector3.MoveTowards(battleshipPrefab.transform.position, waypoint1Position, speed);
	}

    void TargetPositions()
    {
        waypoint1Position = waypoint1.transform.position;
        waypoint2Position = waypoint2.transform.position;
        waypoint3Position = waypoint3.transform.position;
        waypoint4Position = waypoint4.transform.position;
    }


}
