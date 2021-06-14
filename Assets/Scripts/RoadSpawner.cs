﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    public MoveRoad currentRoad;
    public GameObject straightRoad;
    public float roadSpeed;

    private Vector3 startPos;
    private Vector3 spawnPos;
    private float repeatWidth;
    private MoveRoad oldRoad;
    void Start()
    {
        startPos = currentRoad.transform.position;
        repeatWidth = currentRoad.GetComponent<BoxCollider>().size.z / 2;
        spawnPos = new Vector3(startPos.x, startPos.y, startPos.z + repeatWidth);
    }

    void Update()
    {
        if(currentRoad.transform.position.z < startPos.z - repeatWidth) {
            SpawnRoad();
        }
        if(currentRoad.transform.position.z < -currentRoad.GetComponent<BoxCollider>().size.z) {
            SetNewCurrentRoad();
            DestroyOldRoad();
        }
    }

    void SpawnRoad() {
        Instantiate(straightRoad, spawnPos, currentRoad.transform.rotation);
    }

    void DestroyOldRoad() {
        Destroy(oldRoad.gameObject);
    }

    void SetNewCurrentRoad() {
        oldRoad = currentRoad;
        currentRoad = GameObject.FindGameObjectsWithTag("Road")[1].GetComponent<MoveRoad>();
    }
}
