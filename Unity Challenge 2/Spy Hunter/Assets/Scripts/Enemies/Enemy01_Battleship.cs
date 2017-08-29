using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy01_Battleship : MonoBehaviour {

    public GameObject battleshipPrefab;

    public GameObject waypoint1;
    public GameObject waypoint2;
    public GameObject waypoint3;
    public GameObject waypoint4;

    public float waypoint1MoveTime;
    public float waypoint2MoveTime;
    public float waypoint3MoveTime;
    public float waypoint4MoveTime;

    private float timer = 0;

    private Vector3 waypoint1Position;
    private Vector3 waypoint2Position;
    private Vector3 waypoint3Position;
    private Vector3 waypoint4Position;

    private Vector3 battleshipCurrentPosition;

    public float speed;

    private bool hasReachedWaypoint1 = false;
    private bool hasReachedWaypoint2 = false;
    private bool hasReachedWaypoint3 = false;
    private bool hasReachedWaypoint4 = false;

    private bool hasPlayerArrived = false;
    public float initialDelay = 5;
    private float initialDelayTimer = 0; 


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        initialDelayTimer += Time.deltaTime;

        if (initialDelayTimer >= initialDelay)
        {
            Timer();
            TargetPositions();
            MoveBattleShip();
            //MoveBattleShipSimplified();
        }
     }


    void TargetPositions()
    {
        waypoint1Position = waypoint1.transform.position;
        waypoint2Position = waypoint2.transform.position;
        waypoint3Position = waypoint3.transform.position;
        waypoint4Position = waypoint4.transform.position;
    }

    void Timer()
    {
        timer += Time.deltaTime;
        //Debug.Log(timer);
    }

    void MoveBattleShip()
    {
        if (hasReachedWaypoint1 == false && hasReachedWaypoint2 == false && hasReachedWaypoint3 == false && hasReachedWaypoint4 == false)
        {
            if (timer <= waypoint1MoveTime)
            {
                battleshipPrefab.transform.position = Vector3.MoveTowards(battleshipPrefab.transform.position, waypoint1Position, speed);
                battleshipPrefab.transform.rotation = Quaternion.Euler(0, -100, 0);
            }

            else
            {
                timer = 0;
                hasReachedWaypoint1 = true;
            }

        }

        else if (hasReachedWaypoint1 == true && hasReachedWaypoint2 == false && hasReachedWaypoint3 == false && hasReachedWaypoint4 == false)
        {
            if (timer <= waypoint2MoveTime)
            {
                battleshipPrefab.transform.position = Vector3.MoveTowards(battleshipPrefab.transform.position, waypoint2Position, speed);
                battleshipPrefab.transform.rotation = Quaternion.Euler(0, -80, 0);
            }

            else
            {
                timer = 0;
                hasReachedWaypoint2 = true;
            }

        }

        else if (hasReachedWaypoint1 == true && hasReachedWaypoint2 == true && hasReachedWaypoint3 == false && hasReachedWaypoint4 == false)
        {
            if (timer <= waypoint3MoveTime)
            {
                battleshipPrefab.transform.position = Vector3.MoveTowards(battleshipPrefab.transform.position, waypoint3Position, speed);
                battleshipPrefab.transform.rotation = Quaternion.Euler(0, -95, 0);
            }

            else
            {
                timer = 0;
                hasReachedWaypoint3 = true;
            }

        }

        else if (hasReachedWaypoint1 == true && hasReachedWaypoint2 == true && hasReachedWaypoint3 == true && hasReachedWaypoint4 == false)
        {
            if (timer <= waypoint4MoveTime)
            {
                battleshipPrefab.transform.position = Vector3.MoveTowards(battleshipPrefab.transform.position, waypoint4Position, speed);
                battleshipPrefab.transform.rotation = Quaternion.Euler(0, -80, 0);
            }

            else
            {
                timer = 0;
                hasReachedWaypoint3 = true;
            }

        }
    }
}
