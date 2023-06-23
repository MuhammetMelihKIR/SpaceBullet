using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager :MonoBehaviour
{
    public static GameManager instance;


    public List<GameObject> enemies = new List<GameObject>();

    public int enemyCounter;

    [Header("TIMER")]
    [SerializeField]  float _delay;
    [SerializeField]  float _delay2;
    private float _timer;
    [Space]

    public bool _gameReady = false;
    public int nextSceneLoad;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            
        }
        _gameReady = false;
    }

    private void Start()
    {
        enemyCounter = enemies.Count;
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;

    }
    private void Update()
    {

        if (Magazine.instance.bulletCounter <= 0 && enemyCounter > 0)
        {
            GameManager.instance.LosePanelWithTimer();

        }
    }


    public void GameStart()
    {
        _gameReady = true;
        UIManager.instance.GameReadyClose();
       
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);

    }
    public void NextLevel()
    {
        _timer += Time.deltaTime;
        if (_timer > _delay2)
        {
            SceneManager.LoadScene(nextSceneLoad);

            
            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }

            _timer -= _delay2;


        }
    }

    public void LosePanelWithTimer()
    {
        
        _timer += Time.deltaTime;
        if (_timer > _delay)
        {
            
            UIManager.instance.LosePanelActive();
             _timer -= _delay;
            
           
        }
    }

    public void LevelButton()
    {
        SceneManager.LoadScene(nextSceneLoad);
    }









}
