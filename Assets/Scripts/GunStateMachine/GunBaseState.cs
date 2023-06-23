
using UnityEngine;

public abstract class GunBaseState
{
    
    public abstract void EnterState(GunStateManager gun);
    public abstract void UpdateState(GunStateManager gun);
    public abstract void OnCollisionEnter (GunStateManager gun);
}
