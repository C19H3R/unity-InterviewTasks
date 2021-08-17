using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballPlayer : MonoBehaviour
{
    [SerializeField]
    Rigidbody _rb;

    Vector3 movementForce = Vector3.zero;
    [SerializeField]
    float _forceValue = 10f;
    void Start()
    {

    }


    void Update()
    {
        movementForce.x = InputManager.HorizontalFootball;
        movementForce.z = InputManager.VerticalFootball;

        _rb.AddForce(movementForce * Time.deltaTime * _forceValue, ForceMode.Acceleration);
    }
}
