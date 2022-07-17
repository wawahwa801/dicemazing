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
    void Update()
    {
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                gameObject.SetActive(false);
                nextLevel.Setactive(true);
                wall.SetActive(true);
            }
        }
    }
}
