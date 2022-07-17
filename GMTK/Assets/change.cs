using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Sprite diceOne;
    public Sprite diceTwo;
    public Sprite diceThree;
    public Sprite diceFour;
    public Sprite diceFive;
    public Sprite diceSix;
    public float dice = 6;
    private float timeleft = 3f;
    // Update is called once per frame
    void FixedUpdate()
    {
        timeleft -= Time.deltaTime;
        if (timeleft <= 0)
        {
            dice++;
            timeleft = 3;
        }
        if (dice % 6 == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = diceOne;
        }
        else if (dice % 6 == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = diceTwo;
        }
        else if (dice % 6 == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = diceThree;
        }
        else if (dice % 6 == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = diceFour;
        }
        else if (dice % 6 == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = diceFive;
        }
        else if (dice % 6 == 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = diceSix;
        }
    }
}
