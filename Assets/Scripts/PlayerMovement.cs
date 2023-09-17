using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // get player rigidbody
    private Rigidbody2D player;
    private Animator anim;
    private SpriteRenderer sprite;

    private float dirX = 0f;
    // SerializeField allows private variables to be edited in Unity inspector
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpHeight = 14f;
    
    private enum State { idle, running, jumping, falling }
    private State state = State.idle;

    // Start is called before the first frame update
    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        // move horizontally
        player.velocity = new Vector2(dirX * moveSpeed, player.velocity.y);

        // jump with button down
        if (Input.GetButtonDown("Jump"))
        {
            player.velocity = new Vector2(player.velocity.x, jumpHeight);
        }

        // update animation state
        updateAnimationState();
    }

    // update animation state
    private void updateAnimationState()
    {
        // get current state
        State state;

        // moving right
        if (dirX > 0f)
        {
            state = State.running;
        }
        // moving left
        else if (dirX < 0f)
        {
            state = State.running;
        }
        // not moving
        else
        {
            state = State.idle;
        }

        // jumping
        if (player.velocity.y > 0.1f)
        {
            state = State.jumping;
        }
        // falling
        else if (player.velocity.y < -0.1f)
        {
            state = State.falling;
        }
        // not jumping or falling
        else
        {
            state = State.idle;
        }

        anim.SetInteger("state", (int)state);
    }
}
