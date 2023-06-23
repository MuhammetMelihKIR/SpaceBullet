
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class GunMoveState : GunBaseState
{
    
    public override void EnterState(GunStateManager gun)
    {
        
    }

    public override void UpdateState(GunStateManager gun) 
    {
        if (Magazine.instance.bulletCounter > 0) 
        {
            Vector3 vec = new Vector3(gun.transform.position.x, gun.transform.position.y, 30 - (Mathf.PingPong(Time.time * 75, 60)));

            gun.transform.localEulerAngles = vec;
        }
       

        if (Input.GetMouseButtonDown(0) && Ship.Instance.shootOn==true)
        {
            
            gun.SwitchState(gun.stopState);
        }

        
    }

    public override void OnCollisionEnter(GunStateManager gun)
    {
    }

    
}
