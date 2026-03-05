using UnityEngine;

public class WalkingState : BasePlayerState
{
    public WalkingState(PlayerStateController _player) : base(_player)
    {
        key = 1;
    }
    public override void EnterState()
    {
        base.EnterState();
       
    }

    public override void ExitState()
    {
        base.ExitState();
    }

 
    public override void FixedUpdate()
    {
        base.FixedUpdate();
    }
}

