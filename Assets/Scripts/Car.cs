using UnityEngine;

public class Car : Vehicle
{
    protected override void Move()
    {
        float moveInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");

        float targetSpeed = maxSpeed * moveInput;

        if(moveInput == 0)
        {
            currentSpeed = Mathf.MoveTowards(currentSpeed, 0, deceleration * Time.deltaTime);
        }
        else
        {
            currentSpeed = Mathf.MoveTowards(currentSpeed, targetSpeed, acceleration * Time.deltaTime);
        }

        rb.linearVelocity = transform.forward * currentSpeed;

        if(Mathf.Abs(currentSpeed) > 0.1f)
        {
            float turnAmount = turnInput * turnSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up, turnAmount);
        }
    }
}
