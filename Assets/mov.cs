using UnityEngine;
using System.Collections;

public class Mov : MonoBehaviour{


    // the funtion to add force to a Rigidbody is Rigidody.AddFForce (vector 3)
    // Use this for initialization
    private Rigidbody rb;
    public float speed, jumpForce;


    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        float xVel = Input.GetAxis("Horizontal"); //Input manager returns between -1 and 1
        float zVel = Input.GetAxis("Vertical");

        Vector3 moveForce = new Vector3(0, 0, 0);
        moveForce.x = xVel*speed;
        moveForce.z = zVel*speed;

        if(Input.GetButtonDown("Jump"))
        {
            moveForce.y = jumpForce;
        }
        rb.AddForce(moveForce);
    }

}
