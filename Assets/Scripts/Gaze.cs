using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gaze : MonoBehaviour
{
    RaycastHit hitInfo;
    public float power;
    public static GameObject currentlyFocused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Physics.Raycast(transform.position, transform.forward, out hitInfo))
            {
            currentlyFocused = hitInfo.collider.gameObject;
            Debug.Log("Object Detected");
           // hitInfo.collider.gameObject.GetComponent<Rigidbody>().useGravity = true;    
        }
        else
        {
            currentlyFocused = null;
        }
    }
}
