using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseMenu;
    private bool isPaused = false;
	
	// Update is called once per frame
	void Update () {

    if(Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    		
	}

    public void Pause()
    {
        if (isPaused == false)
        {
            isPaused = true;
            pauseMenu.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

        else
        {
            isPaused = false;
            pauseMenu.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
