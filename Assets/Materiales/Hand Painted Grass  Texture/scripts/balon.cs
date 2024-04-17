using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baloncito : MonoBehaviour
{
    public AudioSource audioFx;
    private Vector3 startPosition;
    public GameObject messiObject;
    private Vector3 messiStartPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        messiStartPosition = messiObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "messi" ) { 
            audioFx.Play();
        }
        if (collision.collider.tag == "arq")
        {
            audioFx.Play();
        }


        if (collision.collider.tag == "gol") {
            transform.position = startPosition;
            messiObject.transform.position = messiStartPosition;
        }


    }
}
