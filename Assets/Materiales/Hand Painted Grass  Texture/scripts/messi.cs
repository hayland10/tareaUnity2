using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class messiScrpt : MonoBehaviour
{
    public int velocidad = 5;
   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("INICIANDO MESSI");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.back * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }

    }
 
}
