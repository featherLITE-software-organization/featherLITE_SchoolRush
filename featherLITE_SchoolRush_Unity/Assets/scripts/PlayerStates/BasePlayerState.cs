using Unity.Mathematics;
using Unity.VisualScripting;
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


        //player.rb.AddForce(new Vector3(0, 0, -40) * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X") * player.mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * player.mouseSensitivity;

        // Update yaw and pitch
        player.yaw += mouseX;
        player.pitch -= mouseY;
        player.pitch = Mathf.Clamp(player.pitch, -90f, 90f); // Prevent flipping

        // Rotate player (yaw)
        player.transform.rotation = Quaternion.Euler(0, player.yaw, 0);

        // Rotate camera (pitch)
        if (player.playerCamera != null)
        {
            player.playerCamera.transform.localRotation = Quaternion.Euler(player.pitch, 0, 0);
        }

    }



    public virtual void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        player.inputVector = new Vector3(horizontal, 0, vertical);


        Vector3 targetVector = Quaternion.Euler(0, player.playerCamera.transform.eulerAngles.y, 0) * player.inputVector * 10;

        Debug.Log(targetVector);

        player.rb.AddForce(1 * Time.deltaTime * (targetVector - player.rb.linearVelocity), ForceMode.Impulse);
    }
}
