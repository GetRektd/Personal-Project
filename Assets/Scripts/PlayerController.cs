using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 0.2f;

    public float verticalInput;

    public float rotationSpeed = 75;

    Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * 0.2f);
        transform.Rotate(Vector3.left * rotationSpeed * verticalInput * Time.deltaTime);


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        

     

       
        
    }
}
