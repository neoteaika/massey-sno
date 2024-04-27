using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    public Rigidbody rbody;

    public float speed = 20f;
    public float lifespan = 12f;

    // Start is called before the first frame update
    void Awake()
    {
        rbody = GetComponent<Rigidbody>();
        rbody.AddRelativeForce(Vector3.forward * speed, ForceMode.Impulse);
        Destroy(gameObject, lifespan);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
