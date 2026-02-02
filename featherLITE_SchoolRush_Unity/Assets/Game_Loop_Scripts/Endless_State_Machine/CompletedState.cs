using UnityEngine;

public class CompletedState : EndlessBaseState
{
    public override void EnterState(EndlessGameLoopStateMachine game)
    {
        game.score += 1;
    }
    public override void UpdateState(EndlessGameLoopStateMachine game)
    {
        game.SwitchState(game.passingState);
    }
    public override void ExitState(EndlessGameLoopStateMachine game)
    {
        game.timeLeft = 300;
    }
}
