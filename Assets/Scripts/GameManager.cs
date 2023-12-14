using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject pausedMenu;
    [SerializeField] private CharacterMovement character;
    private bool isPaused;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pausedMenu.SetActive(true);
            isPaused = true;
        }
        if (isPaused)
        {
            character.enabled = false;
        }
    }

    public void ResumeGame(){
        Time.timeScale = 1;
        isPaused = false;
        pausedMenu.SetActive(false);
    }
    public void ExitGame(){
        Application.Quit();
    }
    public void ExitToMainMenu(){
        SceneManager.LoadScene(0);
    }
}
