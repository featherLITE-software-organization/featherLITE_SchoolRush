using UnityEngine;
using UnityEngine.XR;

public abstract class BasePlayerState
{

    public abstract void EnterState(PlayerStateMachine player);

    public abstract void UpdateState(PlayerStateMachine player);



}
