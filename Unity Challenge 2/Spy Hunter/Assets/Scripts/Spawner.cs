using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject terrain_01;
    public GameObject terrain_02;
    public GameObject terrain_03;

    private GameObject terrainPiece;

    private Vector3 spawnPosition;

    

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    // Looking for collision
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Spawner")
        {
            SpawnTerrain();
        }

    }


    void SpawnTerrain ()
    {
        {
            int targetNumber = Random.Range(1,4);

                if (targetNumber == 1)

                    {
                        spawnPosition = new Vector3
                            (
                                this.gameObject.transform.position.x,
                                this.gameObject.transform.position.y,
                                40.9f
                                
                            );

                        terrainPiece = Instantiate(terrain_01, spawnPosition, Quaternion.identity) as GameObject;
                    }

            
                else if (targetNumber == 2)
            {
                {
                    spawnPosition = new Vector3
                        (
                            this.gameObject.transform.position.x,
                            this.gameObject.transform.position.y,
                            45.9f
                            
                        );

                    terrainPiece = Instantiate(terrain_02, spawnPosition, Quaternion.identity) as GameObject;
                }
            }

            else if (targetNumber == 3)
            {
                {
                    spawnPosition = new Vector3
                        (
                            this.gameObject.transform.position.x,
                            this.gameObject.transform.position.y,
                            45.9f
                            
                        );

                    terrainPiece = Instantiate(terrain_03, spawnPosition, Quaternion.identity) as GameObject;
                }
            }





        }
    }




}
