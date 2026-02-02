using UnityEngine;

public class EndlessGameLoopStateMachine : MonoBehaviour
{
    public EndlessBaseState currentState;
    public CompletedState completedState = new CompletedState();
    public FailedState failedState = new FailedState();
    public PassingPeriodState passingState = new PassingPeriodState();
    public EndlessEnteringState enteringState = new EndlessEnteringState();
    public EndlessPausedState pausedState = new EndlessPausedState();
    public EndlessLeavingState leavingState = new EndlessLeavingState();
    public GameObject[] possibleLocations = GameObject.FindGameObjectsWithTag("PossibleLocation");
    public Transform targetLocation;
    public Transform previousLocation;
    public int timeLeft;
    public int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        currentState = enteringState;
        currentState.EnterState(this);

    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(EndlessBaseState state)
    {
        currentState.ExitState(this);
        currentState = state;
        currentState.EnterState(this);
    }
}
