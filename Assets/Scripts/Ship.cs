using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Ship : MonoBehaviour
{
    public static Ship Instance;
    public bool shootOn =false;
    public bool camOn = true;
    [SerializeField] GameObject _magazine;

    [SerializeField] ParticleSystem _explosion;
    [SerializeField] float _speed;
    [SerializeField] Vector3 _moveToStart;
    [SerializeField] Vector3 _moveToEnd;
    Rigidbody2D rigidbody2;

    public enum ShipState
    {
        start,
        stop,
        end,

    }
    public ShipState state;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        rigidbody2= GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        

        if (GameManager.instance._gameReady==true)
        {
            switch (state)
            {

                case ShipState.start:  
                    
                    MoveStartPoint();
                    shootOn = false;
                    camOn = true;
                    UIManager.instance.MagazinePanelClose();                   
                    AudioManager.instance.PlaySearching();

                    break;

                case ShipState.stop:
                    
                    shootOn = true;
                    camOn = true;
                    AudioManager.instance._searchOn = true;
                    UIManager.instance.MagazinePanelActive();
                    break;

                case ShipState.end:

                    MoveEndPoint();
                    shootOn = false;
                    camOn = false;
                    GameManager.instance.NextLevel();
                    
                    

                    break;

            }

            _magazine.transform.position = new Vector3(2.5f, gameObject.transform.position.y, gameObject.transform.position.z);

            if (GameManager.instance.enemyCounter == 0)
            {
                state = ShipState.end;
                UIManager.instance.MagazinePanelClose();
            }


           
        }

       
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("find"))
        {
            state = ShipState.stop;
        }
        if (other.CompareTag("enemy"))
        {
            gameObject.SetActive(false);
            UIManager.instance.LosePanelActive();
            UIManager.instance.MagazinePanelClose();

        }
    }
    public void MoveStartPoint()
    {
        transform.position = Vector3.MoveTowards(transform.position, _moveToStart, _speed * Time.deltaTime);
        
    }

    public void MoveEndPoint()
    {
        transform.position = Vector3.MoveTowards(transform.position, _moveToEnd, _speed * Time.deltaTime);
    }
}
