using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coldetection : MonoBehaviour
{
    public Movement move;
    public GameObject lastp;
    public int score = 0;

    void Start()
    {
        move = this.GetComponent<Movement>();
        
    }


    void OnCollisionStay(Collision other)
    {


        if (other.collider.tag == "Stopper")
        {
            Debug.Log("Stopped");
            move.moveme = false;
            move.moving = false;

        }

    }

}
