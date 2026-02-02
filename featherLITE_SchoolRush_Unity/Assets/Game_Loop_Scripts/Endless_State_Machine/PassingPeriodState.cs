using UnityEngine;

public class PassingPeriodState : EndlessBaseState
{
    public float timeSinceLastSecond;
    public float goalSize;
    
    public override void EnterState(EndlessGameLoopStateMachine game)
    {
        if(game.targetLocation != null)
        {
            game.previousLocation = game.targetLocation;
        }
        while(game.previousLocation == game.targetLocation)
        {
            game.targetLocation = game.possibleLocations[Random.Range(0, game.possibleLocations.Length)].transform;
        }
    }
    public override void UpdateState(EndlessGameLoopStateMachine game)
    {
        if(Vector3.Distance(game.gameObject.transform.position, game.targetLocation.position) < goalSize)
        {
            game.SwitchState(game.completedState);
        }
        timeSinceLastSecond += Time.deltaTime;
        if (timeSinceLastSecond > 1f)
        {
            timeSinceLastSecond %= 1f;
            game.timeLeft -= 1;
        }
    }
    public override void ExitState(EndlessGameLoopStateMachine game)
    {

    }
}
