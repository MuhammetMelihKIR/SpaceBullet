using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    public Button[] buttons;
    public int buttonValue;
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);

        for (int i = 0; i < buttons.Length; i++)
        {
            if (i+2 >levelAt)
            {
                buttons[i].interactable = false;
                
            }
        }

    }
    
}
