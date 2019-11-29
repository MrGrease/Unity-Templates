using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 movement;
    public float speed = 1f;
    public bool moveme = false;
    private Vector3 origin;
    float mouseXValue, mouseYValue;
    public float dragSpeed = 2;
    private Vector3 dragOrigin;
    public bool moving = false;
    public Vector3 backup =new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {

        moveme = false;
        GetComponent<Rigidbody>().transform.position = new Vector3(0, 0, 0);

    }


    // Update is called once per frame
    void FixedUpdate()
    {
       

        if (moveme)
        {

            //Move the object with our vector3
            //GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime, ForceMode.Impulse);
            GetComponent<Rigidbody>().velocity = movement;


        }
        else
        {

                Debug.Log("Reset pos");
                GetComponent<Rigidbody>().transform.position = backup;
            
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            
        }
    }



    public void mouseup()
    {
        Debug.Log("Mouse Up.");
        
    }
    public void mousedown()
    {
        Debug.Log("Mouse Down.");
        if (!moving)
        {
            dragOrigin = Input.mousePosition;
        }
    }
    public void mousedrag()
    {
        if (!moving)
        {
            Vector3 pos = Input.mousePosition - dragOrigin;

            pos.z = pos.y;

            pos.y = 0;

            Debug.Log("Mouse Dragged." + pos);

            if (Mathf.Abs(pos.z) > Mathf.Abs(pos.x))
            {
                if (pos.z < 0)
                {
                    movement = new Vector3(0f, 0f, -1 * 20f);
                }
                else
                {
                    movement = new Vector3(0f, 0f, 1 * 20f);
                }

            }
            else
            {
                if (pos.x < 0)
                {
                    movement = new Vector3(-1 * 20f, 0f, 0f);
                }
                else
                {
                    movement = new Vector3(1 * 20f, 0f, 0f);
                }
            }

            moveme = true;
            moving = true;
        }
    }
}
