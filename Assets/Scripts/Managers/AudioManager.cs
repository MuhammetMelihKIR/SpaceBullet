using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [Header("Sounds")]
    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioSource _sourceBackground;
    [SerializeField] AudioClip _shoot;
    [SerializeField] AudioClip _explosion;
    [SerializeField] AudioClip _searching;
    [SerializeField] AudioClip _background;
    [SerializeField] AudioClip _levelButtonSound;
 
    [Space]
    [Header("Sound Button")]
    [SerializeField] Button _soundButton;
    [SerializeField] Sprite _soundOn;
    [SerializeField] Sprite _soundOff;



    public bool audioON = true;
    public bool _searchOn=true;
    private void Awake()
    {
        instance = this;

       DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
       
        _sourceBackground.PlayOneShot(_background);

    }

    

    public void LevelButtonSounds()
    {
        _audioSource.PlayOneShot(_levelButtonSound);
    }
    public void PlaySearching()
    {
        if(_searchOn)
        {
            if (audioON)
            {
                _audioSource.PlayOneShot(_searching);
                _searchOn= false;
            }
        }
        
        
    }
   
    public void PlayShoot()
    {
        if (audioON)  _audioSource.PlayOneShot(_shoot);


    }

    public void PlayExplosion()
    {
        if (audioON)  _audioSource.PlayOneShot(_explosion);
    }

    public void SoundButton()
    {
        
        
        if (audioON)
        {
            _soundButton.image.sprite = _soundOff;
            _audioSource.volume = 0;
            _sourceBackground.volume = 0;
            audioON = false;
            
        }
        else if(!audioON)
        {
            _soundButton.image.sprite = _soundOn;
            _audioSource.volume = 1;
            _sourceBackground.volume = 0.11f;
            audioON = true;
 
        }
        
    }
}
