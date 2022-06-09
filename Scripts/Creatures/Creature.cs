using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class Creature : MonoBehaviour
{
    // 
    private float m_speed;


    [SerializeField] protected Rigidbody rigidBody;
    [SerializeField] protected float maxSpeed;
    [SerializeField] protected float flyDistance;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Debug.Log(GetMovementInput());
    }


    // Check distance to the ground
    private void DistanceToGround()
    {

    }





     protected abstract Vector3 GetMovementInput();


}
