using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;

    public float translateSpeed = 10f;
    public float physicalSpeed = 60f;

    public bool useAbsoluteMotion;  
    public bool usePhysicalMotion;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.GetAxis("Horizontal"));
        horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime * translateSpeed;
        verticalInput = Input.GetAxis("Vertical") * Time.deltaTime * translateSpeed;

        Vector3 movementDirection = new Vector3(horizontalInput, 0f, verticalInput);

        if (useAbsoluteMotion)
        {
            // use absolute
            if (usePhysicalMotion)
            {
                // use force
                GetComponent<Rigidbody>().AddForce(horizontalInput * physicalSpeed, 0f, verticalInput * physicalSpeed);
            }
            // use translate no force
            else
            {
                transform.Translate(movementDirection, Space.World);
            }
        }
        else
        {
            // use relative
            transform.Translate(movementDirection);
        }

        //Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.y = 0f;
        transform.LookAt(mousePosition);

    }
}
