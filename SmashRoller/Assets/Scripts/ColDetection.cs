using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColDetection : MonoBehaviour
{
    public int scoreval = 0;

    void OnCollisionEnter(Collision collisionInfo)
    {
        // Figure out what our game object has hit
        Debug.Log(gameObject.name + " hit " + collisionInfo.collider.tag);

        // Check if our object is "sticky" i.e. something we can pick up!
        if(collisionInfo.collider.tag == "sticky")
        {
            // Create a fixed joint between the sticky object and the player
            FixedJoint joint = gameObject.AddComponent<FixedJoint>();
            // Set the contact point to the collision point between the two objects
            joint.anchor = collisionInfo.contacts[0].point;
            // Connect!
            joint.connectedBody = collisionInfo.contacts[0].otherCollider.transform.GetComponentInParent<Rigidbody>();
            // Stop them from colliding with each other...
            joint.enableCollision = false;
            //Destroy the box collider of the sticky object so its seems like its a part of the sphere
            Destroy(collisionInfo.collider.GetComponent<BoxCollider>());

            scoreval++;
            Debug.Log("Score:"+scoreval);
        }

    }
}
