using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSelf : MonoBehaviour
{
    float vx, vy;

    // Start is called before the first frame update
    void Start()
    {
        float t = Random.Range(0f, 3.14159264f * 2);
        vx = Mathf.Cos(t) * 8f;
        vy = Mathf.Sin(t) * 8f;
        // transform does not exist yet?
        //Vector3 pos = transform.position;
        //pos.x = 0f;
        //pos.y = 0f;
        //transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if( pos.x < -8 || pos.x > 8 || pos.y < -4 || pos.y > 4 ) {
            Destroy(gameObject);
        }
        pos.x += vx * Time.deltaTime;
        pos.y += vy * Time.deltaTime;
        transform.position = pos;
    }
}
