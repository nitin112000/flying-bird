using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5;
    public float deadzone = -10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position +  (Vector3.left* moveSpeed)*Time.deltaTime; 
        if(transform.position.x < -45)

        {
            Destroy(gameObject);
            Debug.Log("deleted");
        }
        
    }
}
