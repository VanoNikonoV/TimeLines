using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void AddForce()
    {
        rb.AddForce(Vector3.forward * 3, ForceMode.Impulse); 
    }

}
