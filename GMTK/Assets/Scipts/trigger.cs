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
    void Update()
    {
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Player")
            {
                gameObject.SetActive(false);
                nextLevel.SetActive(true);
                wall.SetActive(true);
                nextWin.SetActive(true);
            }
        }
    }
}