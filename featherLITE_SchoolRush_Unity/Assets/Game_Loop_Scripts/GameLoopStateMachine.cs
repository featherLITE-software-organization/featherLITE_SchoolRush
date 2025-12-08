using UnityEngine;

public class GameLoopStateMachine : MonoBehaviour
{
    public BaseGameState currentState;
    public EnteringState enteringState = new EnteringState();
    public PausedState pausedState = new PausedState();
    public LeavingState leavingState = new LeavingState();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
