using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginErrorHandler : MonoBehaviour
{
    //Login Error variables
    public GameObject errorPanel;
    public GameObject errorBox;
    public GameObject errorTxt;
    public static string error;
    public GameObject btnOk;

    // Start is called before the first frame update
    void Start()
    {
        errorPanel = GameObject.Find("ErrorPanel");
        errorTxt = GameObject.Find("Error_Txt");

        btnOk = GameObject.Find("Okay_Btn");
        btnOk.GetComponent<Button>().onClick.AddListener(closeDialogueBox);
    }

    //Function: Close error box
    public void closeDialogueBox() {
        errorPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        errorTxt.GetComponent<Text>().text = error;
    }
}

