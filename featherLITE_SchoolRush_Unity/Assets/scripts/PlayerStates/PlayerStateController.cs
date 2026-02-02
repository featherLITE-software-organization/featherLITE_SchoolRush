using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStateController : MonoBehaviour
{
    public IdleState idleState;
    public WalkingState walkingState;
    public JumpingState jumpingState;
    public SodaState sodaState;

    public Vector3 inputVector;
    public Rigidbody rb;

    public InputActionReference move;
    public InputActionReference jump;

    public BasePlayerState CurrentPlayerState;



    public void Awake()
    {
        idleState = new IdleState(this);
        walkingState = new WalkingState(this);
        jumpingState = new JumpingState(this);
        sodaState = new SodaState(this);
        CurrentPlayerState = idleState;
    }


    public void ChangeState(BasePlayerState newState)
    {
        CurrentPlayerState.ExitState();
        CurrentPlayerState = newState;
        CurrentPlayerState.EnterState();
    }

    public void FixedUpdate()
    {
        CurrentPlayerState.FixedUpdate();
    }
    private void Update()
    {
        CurrentPlayerState.Update();
    }
}

