using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject gameobj1;
    public GameObject gameobj2;
    public GameObject gameobj3;
    public GameObject gameobj4;
    public GameObject gameobj5;

    //Create an Array to Store Objects Picked up
    public static string[] s1 = new string[5];
    public List<string> inventory = new List<string>();


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(gameobj1);
        Instantiate(gameobj2);
        Instantiate(gameobj3);
        Instantiate(gameobj4);
        Instantiate(gameobj5);



    }
}

