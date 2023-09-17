using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;

    // Update is called once per frame
    private void Update()
    {
        // follow player
        transform.position = new Vector3(
            GameObject.Find("Player").transform.position.x,
            GameObject.Find("Player").transform.position.y,
            transform.position.z
        );
    }
}
