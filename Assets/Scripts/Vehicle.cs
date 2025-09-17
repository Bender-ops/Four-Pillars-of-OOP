using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public abstract class Vehicle : MonoBehaviour
{

    [Header("Movement Settings")]
    [SerializeField] protected float maxSpeed = 20f;
    [SerializeField] protected float acceleration = 10f;
    [SerializeField] protected float deceleration = 15;
    [SerializeField] protected float turnSpeed = 150f;

    protected Rigidbody rb;
    protected float currentSpeed = 0f;


    
    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            Debug.LogError("Vehicle requires a Rigidbody component");
            return;
        }

        rb.useGravity = true;
        
    }

    
    protected virtual void Update()
    {
        Move();
    }

    protected abstract void Move();

    public float GetCurrentSpeed()
    {
        return currentSpeed;
    }
}
