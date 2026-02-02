using UnityEngine;

public class EndlessEnteringState : EndlessBaseState
{
    public override void EnterState(EndlessGameLoopStateMachine game)
    {

    }
    public override void UpdateState(EndlessGameLoopStateMachine game)
    {
        game.SwitchState(game.passingState);
    }
    public override void ExitState(EndlessGameLoopStateMachine game)
    {

    }
}
