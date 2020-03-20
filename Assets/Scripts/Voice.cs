using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Voice : MonoBehaviour
{
    KeywordRecognizer recog;
    // Start is called before the first frame update
   
    void Start()
    {
        string[] wordlist = { "hello", "drop", "right", "left", "stop" };
        recog = new KeywordRecognizer(wordlist, ConfidenceLevel.Low);

        recog.OnPhraseRecognized += Recognized;

        recog.Start();
    }

    private void Recognized(PhraseRecognizedEventArgs args)
    {
        if(args.text == "hello")
        {
            Debug.Log("Hello World");
        }
        if (args.text == "drop")
        {
            GameObject obj = GameObject.Find("Cube");
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            rb.useGravity = true;
        }
        if (args.text == "right")
        {
            GameObject obj = GameObject.Find("Cube");
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            rb.AddForce(10,0,0);
        }
        if (args.text == "left")
        {
            GameObject obj = GameObject.Find("Cube");
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            rb.AddForce(-10, 0, 0);
        }
        if (args.text == "stop")
        {
            GameObject obj = GameObject.Find("Cube");
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            
            rb.AddForce(0, 0, 0);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
