using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("rotateBack");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);

    }

    IEnumerator rotateBack()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            transform.eulerAngles += new Vector3(0, 180, 0);
        }

    }
}
