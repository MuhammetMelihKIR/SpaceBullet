using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{


    public void LevelButton()
    {
        AudioManager.instance.LevelButtonSounds();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    
}
