﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour {
    public GameObject wall;
    public GameObject enemy;

    public float minDistanceFromPlayer = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            //Debug.Log("Trying to spawn...");
            Vector3 spawnPoint = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
            if (Vector3.Distance(spawnPoint, GameObject.FindGameObjectWithTag("Player").transform.position) >= minDistanceFromPlayer)
            {
                Instantiate(enemy, spawnPoint, transform.rotation);
            }
        }
        if (Input.GetButtonDown("Fire2"))
        {
            //Debug.Log("Trying to spawn...");
            Vector3 spawnPoint = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
            if (Vector3.Distance(spawnPoint, GameObject.FindGameObjectWithTag("Player").transform.position) >= minDistanceFromPlayer)
            {
                Instantiate(wall, spawnPoint, transform.rotation);
            }
        }
    }
}
