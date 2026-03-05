using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStateController : MonoBehaviour
{
    public IdleState idleState;
    public WalkingState walkingState;
    public JumpingState jumpingState;
    public SodaState sodaState;
    public RegularState regularState;

    public Vector3 inputVector;
    public Rigidbody rb;

    public InputActionReference move;
    public InputActionReference jump;

    public BasePlayerState CurrentPlayerState;

    public float movementAccelFactor;

    public Camera playerCamera;

    public GameObject gravityObject;

    public LayerMask groundMask;

    public float startingGravity;

    public float fallingAcceleration;

    public CapsuleCollider playerCollider;
    public float mouseSensitivity = 3.0f;
    [HideInInspector] public float yaw = 0f;
    [HideInInspector] public float pitch = 0f;
    public void Awake()
    {
        //idleState = new IdleState(this);
        //walkingState = new WalkingState(this);
        //jumpingState = new JumpingState(this);
        //sodaState = new SodaState(this);
        regularState = new RegularState(this);
        CurrentPlayerState = regularState;
        //CurrentPlayerState = idleState;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
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

