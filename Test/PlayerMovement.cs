using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;

    Vector3 movement;
    Animator anim;
    Rigidbody playerRigidbody;
    int floorMask;
    float camRayLength = 100f;

    void Awake()
    {
        //Create a layer mask for the floor layer.
        floorMask = LayerMask.GetMask("Floor");

        //Setup references.
        anim = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        //Store the input axes.
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");


        //Move the player around the scene.
        Move(h, v);

        //Turn the player to face the mouse cursor.
        Turning();

        //Animate the player
        Animating(h, v);
    }

    void Move(float h, float v)
    {
        //Set the movement vector based on the axis input.
        movement.Set(h, 0f, v);

        //Normalise the movement vector and make it proportional to the speed per secound.
        movement = movement.normalized * speed * Time.deltaTime;

        //Move the player to it's current position plus the movement.
        playerRigidbody.MovePosition(transform.position + movement);
    }

    void Turning()
    {
        //Create a ray from the mouse cursor on screen in the direction of the camera.
        

    }
}
