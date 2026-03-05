using UnityEngine;

public class RegularState : BasePlayerState
{
    float fallingTimer;
    public RegularState(PlayerStateController _player) : base(_player)
    {
        this.player = _player;
        key = 0;
    }




    public override void Update()
    {
        base.Update();

        if (!Physics.CheckBox(player.gravityObject.transform.position, new Vector3(player.playerCollider.radius, player.playerCollider.radius, 0.01f),new Quaternion(0,0,0,0),(int)Mathf.Log(player.groundMask.value,2)))
        {
            player.rb.AddForce(0, -player.startingGravity*fallingTimer, 0);
            fallingTimer += Time.deltaTime * player.fallingAcceleration;
        }
        else
        {
            fallingTimer = 1;
        }


        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    player.ChangeState(player.sodaState);
        //}


        //if (Input.GetButtonDown("Jump"))
        //{
        //    player.ChangeState(player.jumpingState);
        //}


        //// Transition to the walking state if there is input

        //if (player.transform.position.y > 0.4 && player.transform.position.y != 0)
        //{
        //    Debug.Log("triggered");
        //    Vector3 gravity = new Vector3(0, -10, 0);
        //    player.rb.AddForce(gravity);
        //}
        //if (player.transform.position.y <= 0)
        //{
        //    Vector3 stop = new Vector3(0, 0, 0);
        //    player.rb.linearVelocity = stop;
        //}


    }
}
