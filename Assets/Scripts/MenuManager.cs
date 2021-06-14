using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void LoadLevel (string level) {
        SceneManager.LoadScene(level);
    }
}
