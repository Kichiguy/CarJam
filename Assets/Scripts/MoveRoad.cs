using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoad : MonoBehaviour
{
    private PlayerController player;
    private RoadSpawner spawner;
    private double destroyPoint;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        spawner = GameObject.FindGameObjectWithTag("GameController").GetComponent<RoadSpawner>();
        destroyPoint = GetComponent<BoxCollider>().size.z * -1.5;
    }

    void Update()
    {
        if(!player.paused) {
            //TODO: change this to allow for directional changes
            transform.Translate(Vector3.back * Time.deltaTime * spawner.roadSpeed);
            
            if(transform.position.z < destroyPoint) {
                Destroy(gameObject);
            }
        }
    }
}
