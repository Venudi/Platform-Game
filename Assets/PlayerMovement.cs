using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // get player rigidbody
    private Rigidbody2D player;
    
    // Start is called before the first frame update
    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        // move horizontally
        player.velocity = new Vector2(Input.GetAxis("Horizontal") * 10, player.velocity.y);

        // jump with button down
        if (Input.GetButtonDown("Jump"))
        {
            player.velocity = new Vector2(player.velocity.x, 10);
        }
    }
}
