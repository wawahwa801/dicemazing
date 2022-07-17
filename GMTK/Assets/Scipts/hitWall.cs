using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Sprite diceOne;
    // Update is called once per frame
    void Update()
    {
        
    }
    public Transform respawnPoint;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "wall")
        {
            transform.position = respawnPoint.position;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = diceOne;
        }
    }
}
