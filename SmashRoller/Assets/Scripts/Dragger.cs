using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour
{

    public float speed = 1f;

    void Update() {
        //Get inputs from the keyboard
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Create a vector3 from the inputs
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //Move the object with our vector3
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }


}


