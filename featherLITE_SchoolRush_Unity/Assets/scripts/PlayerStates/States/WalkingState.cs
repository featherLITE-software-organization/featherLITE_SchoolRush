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
        player.rb.AddForce(player.inputVector);
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

