using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float speed;
    public GameObject targetPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            
            GameObject spawnedBullet = Instantiate(bulletPrefab);
            spawnedBullet.transform.position = transform.position;
            Rigidbody bulletRb = spawnedBullet.GetComponent<Rigidbody>();
            bulletRb.AddForce(transform.forward * Time.deltaTime * speed, ForceMode.Impulse);
        }

        int targetCount = GameObject.FindGameObjectsWithTag("Obstacle").Length;
        Debug.Log(targetCount);

        if (targetCount <= 0)
        {
            
            for (int i=1;i<=4;i++)
            {
                GameObject spawnedTarget = Instantiate(targetPrefab);
                float x = Random.Range(-3f, 3f);
                float y = Random.Range(-1f, 1f);
                float z = Random.Range(-3f, 3f);
                float yAngle = Random.Range(0, 180f);
                spawnedTarget.transform.position = new Vector3(x, y, z);
                spawnedTarget.transform.eulerAngles = new Vector3(0, yAngle, 0);
            }
        }
    }
}
