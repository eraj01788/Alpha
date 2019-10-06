using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody player;
    public float Accelerator = 1000f;
    public float Break = -1000f;
    public float SideForce = 500f;
    public float FlySpeed = 50;

    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            player.AddForce(0, 0, Accelerator * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            player.AddForce(0, 0, Break * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            player.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            player.AddForce(-SideForce * Time.deltaTime, 0,0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("space"))
        {
            player.AddForce(0, FlySpeed * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("1"))
        {
            player.AddForce(0, -FlySpeed * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
    }
}
