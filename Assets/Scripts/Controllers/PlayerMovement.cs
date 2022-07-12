using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 1f;
    Rigidbody2D rBody;

    private void Awake(){
        rBody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        Vector2 currentPos = rBody.position;    // get current rigidbody position

        float horizontalInput = Input.GetAxis("Horizontal");    // get input x axis
        float verticalInput = Input.GetAxis("Vertical");        // get input y axis

        Vector2 inputVector = new Vector2(horizontalInput, verticalInput);  // merge x and y input into new vector
        inputVector = Vector2.ClampMagnitude(inputVector, 1);    // corrects speed of diagonal inputs

        Vector2 movement = inputVector * movementSpeed; // applies speed modificator
        Vector2 newPos = currentPos + movement * Time.fixedDeltaTime; // scale movement tot physics frame rate update

        rBody.MovePosition(newPos);
    }
}
