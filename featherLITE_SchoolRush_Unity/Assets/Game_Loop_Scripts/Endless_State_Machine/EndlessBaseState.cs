using UnityEngine;

public abstract class EndlessBaseState
{
    public abstract void EnterState(EndlessGameLoopStateMachine game);

    public abstract void UpdateState(EndlessGameLoopStateMachine game);

    public abstract void ExitState(EndlessGameLoopStateMachine game);
}
