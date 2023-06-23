
using UnityEngine;

public class GunStopState : GunBaseState
{
    
    public override void EnterState(GunStateManager gun)
    {
      
    }

    public override void UpdateState(GunStateManager gun)
    {
        gun.transform.localEulerAngles = gun.transform.localEulerAngles;

        gun.SwitchState(gun.fireState);

    }

    public override void OnCollisionEnter(GunStateManager gun)
    {

    }
}
