using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    [SerializeField] public int hp;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp > 100) hp = 100;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "heal")
        {
            hp = hp + 50;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "mine") hp = hp - 50;
    }
      
    

}
