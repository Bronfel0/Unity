using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    [SerializeField] public int hp;
    [SerializeField] Transform start;
    [SerializeField] Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp > 100) hp = 100;

        if (hp <= 0)
        {
            player.transform.position = start.position;
            hp = 100;

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "heal")
        {
            hp = hp + 50;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "mine") hp = hp - 20;

        if (other.gameObject.tag == "grt") hp = hp - 30;

        if (other.gameObject.tag == "Enemy") hp = hp - 100;
    }
      
    

}
