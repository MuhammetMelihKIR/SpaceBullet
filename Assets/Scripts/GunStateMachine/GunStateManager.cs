using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunStateManager : MonoBehaviour
{
   
     GunBaseState currentState;
    

    public GunMoveState moveState = new GunMoveState();
    public GunStopState stopState = new GunStopState();
    public GunFireState fireState = new GunFireState();

    


    void Start()
    {

        currentState = moveState;
        currentState.EnterState(this);
    }

    
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(GunBaseState state)
    {
        if (state==fireState)
        {
            Magazine.instance.MagazineDec();

        }
        currentState= state;
        state.EnterState(this);


    }




}
