using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    private Button _button;
    public int buttonValue;
    void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(ButtonLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonLevel()
    {
        SceneManager.LoadScene(buttonValue+1);
        AudioManager.instance.LevelButtonSounds();
    }

    
}
