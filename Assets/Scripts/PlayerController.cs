using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PauseMenu menu;
    public bool paused;
    void Start()
    {
        paused = false;
    }

    void Update()
    {
        //Pause button
        if(Input.GetKeyDown(KeyCode.F)) {
            paused = true;
            menu.gameObject.SetActive(true);
        }
    }
}
