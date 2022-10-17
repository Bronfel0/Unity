using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Grenate : MonoBehaviour
{
    [SerializeField] private GameObject Boom;
    [SerializeField] private GameObject Grenat;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {

        
        Boom.SetActive(true);

        Destroy(Grenat, 1);
        
    }
}
