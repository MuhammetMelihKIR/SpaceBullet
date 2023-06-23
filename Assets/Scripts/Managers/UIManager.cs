using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [SerializeField] private GameObject _losePanel;
    [SerializeField] private GameObject _magazinePanel;
    [SerializeField] private GameObject _gameReadyPanel;

   
    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
            Destroy(gameObject);
    }


    

    public void GameReadyClose()
    {
        _gameReadyPanel.SetActive(false);
    }
    public void MagazinePanelClose()
    {
        _magazinePanel.SetActive(false);
    }

    public void MagazinePanelActive()
    {
        _magazinePanel.SetActive(true);
    }

    public void LosePanelActive()
    {
        _losePanel.SetActive(true);
    }
    public void LosePanelClose()
    {
        _losePanel.SetActive(false);
    }
}
