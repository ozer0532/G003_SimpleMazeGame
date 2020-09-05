using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10;

    private Rigidbody rb;
    private Vector3 respawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        respawnPosition = transform.position;
    }

    // FixedUpdate is called once per fixed framerate frame
    void FixedUpdate()
    {
        // Getting input
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        Vector3 moveInput = new Vector3(xInput, 0, yInput);

        // Change the player's velocity
        rb.velocity = moveInput * moveSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hazard")
        {
            transform.position = respawnPosition;
        }
    }
}
