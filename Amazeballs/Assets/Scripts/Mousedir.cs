using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousedir : MonoBehaviour
{
    public Movement ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindWithTag("Player").GetComponent<Movement>();
    }

    void OnMouseDown()
    {
        Debug.Log("Pressed primary button.");
        
    }
    void OnMouseDrag()
    {
        Debug.Log("Pressed primary DRAGGED.");
    }

}
