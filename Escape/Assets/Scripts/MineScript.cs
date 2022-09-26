using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineScript : MonoBehaviour
{
    [SerializeField] private GameObject Boom;
    [SerializeField] private GameObject Mine;
    [SerializeField] private Collider col;

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
        if (collision.gameObject.tag == "Player")
        {
            Destroy(col);

            Boom.SetActive(true);
            
            Destroy(Mine, 3);
        }
    }
}
