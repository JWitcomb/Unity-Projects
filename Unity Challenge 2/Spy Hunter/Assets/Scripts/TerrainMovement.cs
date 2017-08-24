using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainMovement : MonoBehaviour {

    public float movementSpeed = 1;

	// Update is called once per frame
	void Update () {

        float terrainMovement = movementSpeed * Time.deltaTime;

        Vector3 newTerrainPosition = new Vector3(0f, 0f, terrainMovement);

        this.gameObject.transform.position += newTerrainPosition;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Destroyer")
            Destroy(this.gameObject);
    }





}
