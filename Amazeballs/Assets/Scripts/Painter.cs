using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painter : MonoBehaviour

{

    public Material Material1;
    bool painted = false;

    // Start is called before the first frame update
    void Start()
    {
        //this.GetComponent<MeshRenderer>().material = Material1;

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            if (painted == false)
            {
                Debug.Log("Painted!" + this);
                painted = true;
                other.gameObject.GetComponent<Coldetection>().score++;
            }
            this.GetComponent<MeshRenderer>().material = Material1;
            other.gameObject.GetComponent<Movement>().backup = GetComponent<Rigidbody>().transform.position;
            

        }
    }
}
