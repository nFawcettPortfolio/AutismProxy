  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDialogueControl : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Button1();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Button2();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Button3();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Button4();
        }
    }
    void Button1()
    {
        FindObjectOfType<Dialogue>().ChoiceOption1();
    }
    void Button2()
    {
        FindObjectOfType<Dialogue>().ChoiceOption2();
    }
    void Button3()
    {
        FindObjectOfType<Dialogue>().ChoiceOption3();
    }
    void Button4()
    {
        FindObjectOfType<Dialogue>().ChoiceOption4();
    }





}
