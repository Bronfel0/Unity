using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Enemy : MonoBehaviour
{
    [SerializeField] GameObject Me;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "grt")
        {
            Destroy(Me);
        }
    }
}
