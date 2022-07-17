using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public GameObject nextLevel;
    public GameObject wall;
    public GameObject nextWin;
    public Transform respawnPoint;
    public GameObject player1;
    public Transform player2;
    public Sprite diceOne;
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (this.player1.GetComponent<SpriteRenderer>().sprite == diceOne)
            {
                gameObject.SetActive(false);
                nextLevel.SetActive(true);
                wall.SetActive(true);
                nextWin.SetActive(true);
                respawnPoint.position = transform.position;
            }
            else
            {
                player2.position = respawnPoint.position;
            }
        }
    }
}