using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void LeaveGame()
    {
        Debug.Log("leaving Game...");
        Application.Quit();
    }
}
