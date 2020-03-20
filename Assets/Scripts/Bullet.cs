﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    private void OnCollisionEnter(Collision data)
    {
        if(data.collider.tag == "Obstacle")
        {
            Destroy(gameObject);
            Destroy(data.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
