using UnityEditor.Timeline.Actions;
using UnityEngine;

public class BasePlayerState
{

    protected PlayerStateController player;

    public int key;
    public BasePlayerState(PlayerStateController _player)
    {
        this.player = _player;
    }
    public virtual void EnterState()
    {

    }

    public virtual void ExitState()
    {

    }

      public virtual void Update()
    {
        // Get input from WASD keys or arrow keys
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Update the input vector
        player.inputVector = new Vector3(horizontal, 0, vertical);

        // Normalize the input vector if its magnitude exceeds 1
        if (player.inputVector.magnitude > 1)
        {
            player.inputVector.Normalize();
        }

        if (player.inputVector.magnitude > 0)
        {
            player.ChangeState(player.walkingState);
        } else if (player.inputVector.magnitude == 0 && player.rb.linearVelocity.y == 0 )
        {
            player.ChangeState(player.idleState);
        }

        if (Input.GetButtonDown("Jump"))
        {
            player.ChangeState(player.jumpingState);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            player.ChangeState(player.sodaState);
        }
        // Transition to the walking state if there is input

        if (player.transform.position.y > 0.4 && player.transform.position.y != 0)
        {
            Debug.Log("triggered");
            Vector3 gravity = new Vector3(0, -10, 0);
            player.rb.AddForce(gravity);
        }
        if (player.transform.position.y <= 0)
        {
            Vector3 stop = new Vector3(0, 0, 0);
            player.rb.linearVelocity = stop;
        }

        if (player.rb.linearVelocity.x > 0)
        {
          if(player.inputVector.magnitude == 0)
            {
                player.inputVector.Normalize();
            }
        }
        Debug.Log(player.CurrentPlayerState);
    }

    

    public virtual void FixedUpdate()
    {

    }
}
