using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cilindro : MonoBehaviour
{
    [SerializeField]
    private Vector3 destiny;

    private Vector3 origin;
    private bool descendo;

    private void Start()
    {
        origin = transform.position;
    }

    private void Update()
    {
        if(descendo && transform.position != destiny)
        {
            //lerp to destiny
            //after lerp: descendo == false
        }
        else if (transform.position == destiny)
        {
            //lerp to origin
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("marreta"))
            descendo = true;
    }

}
