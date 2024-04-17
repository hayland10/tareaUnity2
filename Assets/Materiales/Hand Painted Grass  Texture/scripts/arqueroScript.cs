using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arquero : MonoBehaviour
{
    public int velocidad = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Arquero Listo");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L)) {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
    }
}
