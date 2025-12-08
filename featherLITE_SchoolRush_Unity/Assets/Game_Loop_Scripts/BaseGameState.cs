using UnityEngine;

public abstract class BaseGameState
{
    public abstract void EnterState(GameLoopStateMachine game);

    public abstract void UpdateState(GameLoopStateMachine game);

    public abstract void ExitState(GameLoopStateMachine game);
}
