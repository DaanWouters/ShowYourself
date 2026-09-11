using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    private void Start()
    { 
        pauseMenu.SetActive(false); 
    }
    
    private void Update() 
    { 
        if (Keyboard.current.escapeKey.wasPressedThisFrame) 
        { 
            bool isPaused = pauseMenu.activeSelf;
            pauseMenu.SetActive(!isPaused); 
            Time.timeScale = isPaused ? 1f : 0f; 
        } 
    }


}
