using UnityEngine;
using UnityEngine.InputSystem;

public class JumpingState : BasePlayerState
{
    public JumpingState(PlayerStateController _player) : base(_player)
    {
        key = 2;
    }
    public override void EnterState()
    {
        base.EnterState();
        player.inputVector = new Vector3(0, 150, 0);
        player.rb.AddForce(player.inputVector);
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
        
    }
    public override void ExitState()
    {
        base.ExitState();
    }
}
