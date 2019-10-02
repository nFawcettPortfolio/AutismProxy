using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemyMoving : MonoBehaviour
{
    public Animator Remy;
    // Start is called before the first frame update
    void Start()
    {
        Remy = GetComponent<Animator>();
        InvokeRepeating("SetRandomPos", 0, 1);

    }

    // Update is called once per frame
    void Update()
    {

        Remy.SetBool("IsWalking", true);
        Remy.SetFloat(10, 15);
        Remy.SetFloat(10, 25);


    }

    void SetRandomPos()
    {
    //  Vector3 temp = new Vector3(Random.range(-10.6f, 10.6f), Random.range(-10.6f, 10.6f), Random.range(-10.6f, 10.6f));
      //transform.position = temp;
    }
}
