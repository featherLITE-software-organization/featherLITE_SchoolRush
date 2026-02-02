using UnityEngine;
using UnityEngine.InputSystem;

public class IdleState : BasePlayerState
{
    public IdleState(PlayerStateController _player) : base(_player)
    {
        key = 3;
    }
    public override void EnterState()
    {
        base.EnterState();
        Debug.Log("hello1");
        player.inputVector = Vector3.zero;
    }

    public override void Update()
    {
        base.Update();

    }
    public override void ExitState()
    {
        base.ExitState();
    }
}
