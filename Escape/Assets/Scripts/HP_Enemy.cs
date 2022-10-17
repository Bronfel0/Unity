using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Enemy : MonoBehaviour
{
    [SerializeField] private LayerMask _mask;
    [SerializeField] private Transform _player;
    [SerializeField] GameObject Me;
    [SerializeField] private Camera mainCamera;
    [SerializeField] GameObject _bullet;

    
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
    

    private void FixedUpdate()
    {
        
        
    }
}
