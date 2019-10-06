using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Choice1;
    public GameObject Choice2;
    public GameObject Choice3;
    public GameObject Choice4;
    public int nodePos;

    [System.Serializable]
    public class DialogueNode{

        [Header("Dialogue")]
        [TextArea(2, 5)]
        public string text;

        [Header("Responses")]
        public bool haveChoice1;
        [TextArea(2,3)]
        public string choice1;
        public int des1;
        [Space]
        public bool haveChoice2;
        [TextArea(2, 3)]
        public string choice2;
        public int des2;
        [Space]
        public bool haveChoice3;
        [TextArea(2, 3)]
        public string choice3;
        public int des3;
        [Space]
        public bool haveChoice4;
        [TextArea(2, 3)]
        public string choice4;
        public int des4;


    }

    [Header("Character Name")]
    public string name;
    [Header("Dialogue Nodes")]
    public DialogueNode[] node = new DialogueNode[3];

    public void ChoiceOption1()
    {
        nodePos = node[nodePos].des1;
        CountineDialogue();
    }
    public void ChoiceOption2()
    {
        nodePos = node[nodePos].des2;
        CountineDialogue();
    }
    public void ChoiceOption3()
    {
        nodePos = node[nodePos].des3;
        CountineDialogue();
    }
    public void ChoiceOption4()
    {
        nodePos = node[nodePos].des4;
        CountineDialogue();
    }

    public void Start()
    {
    }

    public void CountineDialogue()
    {

        TextBox.SetActive(true);
        if (nodePos<0)
        {
            EndDialogue();
            return;
        }

        TextBox.GetComponent<TextMeshProUGUI>().SetText(node[nodePos].text);

        // Choice 1
        if (node[nodePos].haveChoice1)
        {
            Choice1.GetComponentInChildren<TextMeshProUGUI>().SetText(node[nodePos].choice1);
            Choice1.SetActive(true);
        }
        else { Choice1.SetActive(false); }

        // Choice 2
        if (node[nodePos].haveChoice2)
        {
            Choice2.GetComponentInChildren<TextMeshProUGUI>().SetText(node[nodePos].choice2);
            Choice2.SetActive(true);
        }
        else { Choice2.SetActive(false); }

        // Choice 3
        if (node[nodePos].haveChoice3)
        {
            Choice3.GetComponentInChildren<TextMeshProUGUI>().SetText(node[nodePos].choice3);
            Choice3.SetActive(true);
        }
        else { Choice3.SetActive(false); }
        // Choice 4
        if (node[nodePos].haveChoice4)
        {
            Choice4.GetComponentInChildren<TextMeshProUGUI>().SetText(node[nodePos].choice4);
            Choice4.SetActive(true);
        }
        else { Choice4.SetActive(false); }

    }

    private void EndDialogue()
    {
        HideHUD();
    }

    private void HideHUD()
    {
        TextBox.SetActive(false);
        Choice1.SetActive(false);
        Choice2.SetActive(false);
        Choice3.SetActive(false);
        Choice4.SetActive(false);
    }
}


   