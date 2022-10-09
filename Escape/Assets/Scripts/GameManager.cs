using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private GameObject _spawn;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_gameObject, _spawn.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
