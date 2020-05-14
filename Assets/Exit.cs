using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Assets/Exit")]
public class Exit : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
