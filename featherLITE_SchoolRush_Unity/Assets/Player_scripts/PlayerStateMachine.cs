using UnityEngine;
using UnityEngine.InputSystem.XR.Haptics;

public class PlayerStateMachine : MonoBehaviour
{
   

    public BasePlayerState currentPlayerState;
    public RegularState RegularState = new RegularState();
    public JumpingState JumpingState = new JumpingState();






    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentPlayerState = RegularState;

        currentPlayerState.EnterState(this);
    }

    // Update is called once per frame
    public void Update()
    {
        currentPlayerState.UpdateState(this);
    }

    public void SwitchState(BasePlayerState state)
    {
        currentPlayerState = state;
        state.EnterState(this);
    }


}
