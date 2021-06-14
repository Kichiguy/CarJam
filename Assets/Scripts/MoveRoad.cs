using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoad : MonoBehaviour
{
    public float speed;
    public PlayerController player;
    void Start()
    {
        
    }

    void Update()
    {
        if(!player.paused) {
            //TODO: change this to allow for directional changes
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
    }
}
