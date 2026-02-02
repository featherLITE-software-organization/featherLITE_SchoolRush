using UnityEngine;

public class SodaState : BasePlayerState
{
    public SodaState(PlayerStateController _player):base(_player)
    {
        key = 4;
    }
    public override void EnterState()
    {
        base.EnterState();
        player.inputVector = new Vector3(0, 300, 0);
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
