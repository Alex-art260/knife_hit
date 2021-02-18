using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePartLog : MonoBehaviour
{
    public float maxThrust;
    public float maxTorque;
    public Rigidbody2D rb;
    public float speed;

    private void Start()
    {
        Vector2 thrust = new Vector2(Random.Range(-maxThrust, maxThrust), Random.Range(-maxThrust, maxThrust));
        float torque = Random.Range(-maxTorque, maxTorque);

        rb.AddForce(thrust * speed);
        rb.AddTorque(torque * speed);
    }
}
