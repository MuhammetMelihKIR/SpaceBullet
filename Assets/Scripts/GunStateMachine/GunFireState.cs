
using System.Collections.Generic;
using UnityEngine;

public class GunFireState : GunBaseState
{
    [SerializeField] private float _delay = 1;
    private float _timer;
    
    public override void EnterState(GunStateManager gun)
    {
        ObjectPool.instance.GetPoolObject();
        AudioManager.instance.PlayShoot();
        
    }

    public override void UpdateState(GunStateManager gun)
    {
        
        _timer += Time.deltaTime;
        if (_timer > _delay)
        {
            gun.SwitchState(gun.moveState);
            _timer -= _delay;
        }

        
        
        
    }

    public override void OnCollisionEnter(GunStateManager gun)
    {

    }
}
