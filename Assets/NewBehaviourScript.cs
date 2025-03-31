using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float dir = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += dir * Time.deltaTime;
        transform.position = pos;
        if ( pos.x > 6.0 || pos.x < -6.0 ) {
            dir *= -1f;
        }
    }
}
