using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TennisPlayer : MonoBehaviour
{
    [SerializeField]
    Rigidbody _rb;

    Vector3 movementForce=Vector3.zero;
    [SerializeField]
    float _forceValue = 10f;
    void Start()
    {
        
    }


    void Update()
    {
        movementForce.x = InputManager.HorizontalTennis;
        movementForce.z = InputManager.VerticaTennis;

        _rb.AddForce(movementForce*Time.deltaTime*_forceValue,ForceMode.Acceleration);
    }
}
