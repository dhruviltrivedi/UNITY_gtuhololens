using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public Transform planeTrans;
    bool onGround = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision data)
    {
        if(data.gameObject.tag == "Obstacle")
        {
            Debug.Log("GAME OVER");
        }
        if (data.gameObject.name == "Plane")
        {
            onGround = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < planeTrans.position.y)
        {
            Debug.Log("Game Over. You Fell Down the plane");
        }
        rb.AddForce(0, 0, 10);
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-10, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(10, 0, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow) && onGround)
        {
            rb.AddForce(0, 20, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, -10, -25);
        }



    }
}
