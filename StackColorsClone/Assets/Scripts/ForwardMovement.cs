using System;
using System.Collections;
using System.Collections.Generic;
using Lean.Common;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody _rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
    }

    void FixedUpdate()
    {
        //transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        _rigidbody.AddForce(Vector3.forward * _speed, ForceMode.Impulse);
        
    }

    public void LockX()
    {
        LeanManualTranslateRigidbody.Instance.isLocked = true;
    }

    public void UnlockX()
    {
        LeanManualTranslateRigidbody.Instance.isLocked = false;
    }
}
