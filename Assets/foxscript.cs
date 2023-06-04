using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foxscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myRigidbody;
    public float jump;
    void Start()
    {
        gameObject.name = "tail beast";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)  == true)
        {
            myRigidbody.velocity = Vector3.up * jump;
        }
        
    }
}
