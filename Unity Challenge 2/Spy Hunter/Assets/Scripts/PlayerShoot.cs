using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public GameObject projectileSpawnRef;
    private Vector3 projectileSpawnLocation;
    public GameObject bullet;
    private GameObject firedBullet;

    public float timeBetweenShots;
    private float timeBetweenShotsReset;
    private float timebetweenshotscounter;
    private bool canShoot = true;
    private Quaternion bulletRotation;

	// Use this for initialization
	void Start ()
    {
        timeBetweenShotsReset = timeBetweenShots;
        timebetweenshotscounter = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (canShoot == true)
        {
            FireWeapon();
        }

        else
        {
            timebetweenshotscounter += Time.deltaTime;

            if (timebetweenshotscounter >= timeBetweenShots)
            {
                timebetweenshotscounter = 0;
                canShoot = true;
            }
        }


        
	}

    void FireWeapon ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            projectileSpawnLocation = new Vector3 
                (
                    projectileSpawnRef.transform.position.x,
                    projectileSpawnRef.transform.position.y,
                    projectileSpawnRef.transform.position.z
                );

            firedBullet = Instantiate(bullet, projectileSpawnLocation,bullet.transform.rotation) as GameObject;
            canShoot = false;
        }
    }


}
