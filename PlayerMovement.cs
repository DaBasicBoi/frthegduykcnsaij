using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    public Rigidbody rb; 

    public float fowardForce = 2000f;
    public float sidewaysForce = 500f;
    
    // Update is called once per frame
    void FixedUpdate ()
    // use Time.deltaTime to sync frames with force
    {
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }   

        if (rb.position.y < -5f)
        {
           Uded = true;
        }
    }
}   
