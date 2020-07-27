using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform player;
    public Vector3 relativePosition;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + relativePosition;
    }
}
