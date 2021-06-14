using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public MenuManager menu;
    public PlayerController player;

    public void ResumeGame() {
        player.paused = false;
        gameObject.SetActive(false);
    }
    
    public void QuitGame() {
        menu.LoadLevel("Menu");
    }
}
