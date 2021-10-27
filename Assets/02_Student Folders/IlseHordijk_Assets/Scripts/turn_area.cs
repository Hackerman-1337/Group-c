using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn_area : MonoBehaviour
{
    public float turnSpeed = 40f;
    public float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
    }
}
