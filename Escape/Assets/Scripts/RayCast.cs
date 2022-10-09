using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    [SerializeField] private LayerMask _mask;
    [SerializeField] private Transform _player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        RaycastHit hit;

        var startPos = transform.position;
        var dir = _player.position - startPos;

        var rayCast = Physics.Raycast(startPos, dir, out hit, Mathf.Infinity,
        _mask);

        Color color = new Color(0f, 0f, 0f, 0f);

        if (rayCast)
        {
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                color = Color.green;
            }
        }
        Debug.DrawRay(startPos, dir, color);
    }
}
