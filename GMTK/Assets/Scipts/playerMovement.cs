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
    public float moveSpeed = 5f;
    public bool close = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.R))
            close = true;
        if (close == true)
            Application.Quit();
    }
}