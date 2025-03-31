using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
           Debug.Log("logging");

           audioSource = GetComponent<AudioSource>();

           if (!audioSource) 
           {
                Debug.Log("Adding AudioSource");
                audioSource = gameObject.AddComponent<AudioSource>();
           }
    }

    public GameObject bulletToCopy;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float movement_h = horizontalInput * speed * Time.deltaTime;
        float movement_v = verticalInput * speed * Time.deltaTime;
        transform.Translate(new Vector3(movement_h, movement_v, 0));

        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject bullet = Instantiate(bulletToCopy);
            bullet.transform.position = transform.position;
            bullet.SetActive(true);
        }
    }

    public AudioClip soundEffect;
    private AudioSource audioSource;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision occurred with: " + collision.gameObject.name);
        audioSource.clip = soundEffect;
        audioSource.Play(); 
    }
}
