using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowGrenate : MonoBehaviour
{
    public float Force;
    public GameObject grenatePrefab;
    public GameObject minePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ThrowGrenat();
        }
        if (Input.GetMouseButtonDown(1))
        {
            ThrowMine();
        }
    }
    void ThrowGrenat()
    {
        GameObject grenate = Instantiate(grenatePrefab, transform.position, transform.rotation);
        Rigidbody rb = grenate.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * Force, ForceMode.VelocityChange);
    }
    void ThrowMine()
    {
        GameObject mine = Instantiate(minePrefab, transform.position, transform.rotation);
        Rigidbody rb2 = mine.GetComponent<Rigidbody>();
        rb2.AddForce(transform.forward * Force, ForceMode.VelocityChange);
    }
}
