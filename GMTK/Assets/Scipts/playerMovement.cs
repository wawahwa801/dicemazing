using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
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
    public float moveSpeed = 5f;
    public float dice = 6;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            dice++;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
            dice++;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            dice++;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            dice++;
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