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
        // moving right
        if (dirX > 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = false;
        }
        // moving left
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = true;
        }
        // not moving
        else
        {
            anim.SetBool("running", false);
        }
    }
}
