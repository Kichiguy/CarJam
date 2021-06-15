using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    public GameObject straightRoad;
    public PlayerController player;
    public float roadSpeed;
    void Start()
    {
        Instantiate(straightRoad, new Vector3(7, 0, 0), straightRoad.transform.rotation);
        Instantiate(straightRoad, new Vector3(7, 0, 130), straightRoad.transform.rotation);
        Instantiate(straightRoad, new Vector3(7, 0, 260), straightRoad.transform.rotation);
        Instantiate(straightRoad, new Vector3(7, 0, 390), straightRoad.transform.rotation);
    }

    void Update()
    {
        if(!player.paused) {
            if(GameObject.FindGameObjectsWithTag("Road").Length < 4) {
            SpawnRoad();
            }
        }
    }

    void SpawnRoad() {
        Instantiate(straightRoad, transform.position, straightRoad.transform.rotation);
    }
}
