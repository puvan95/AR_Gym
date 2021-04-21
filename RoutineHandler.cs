using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoutineHandler : MonoBehaviour
{
    //ScrollRect variables
    public ScrollRect scrollRect;
    public RectTransform routineBeginner;
    public RectTransform routineIntermediate;
    public RectTransform routineAdvanced;

    //Gameobject variables
    public GameObject panelB;
    public GameObject panelI;
    public GameObject panelA;

    public GameObject btnSwitchR;
    public GameObject btnSwitchL;
    public Text txtDifficulty;

    public int count;
    private string[] difficulty;


    // Start is called before the first frame update
    void Start() {

        //Finding Gameobjects during runtime
        panelB = GameObject.Find("ScrollPanel_b");
        panelI = GameObject.Find("ScrollPanel_i");
        panelA = GameObject.Find("ScrollPanel_a");

        panelB.SetActive(true);
        panelI.SetActive(false);
        panelA.SetActive(false);

        btnSwitchR = GameObject.Find("Change_R_Btn");
        btnSwitchL = GameObject.Find("Change_L_Btn");

        count = 0;
        difficulty = new string[3]; //Creating array of difficulty types

        difficulty[0] = "Beginner			12 Weeks";
        difficulty[1] = "intermediate		12 Weeks";
        difficulty[2] = "Advanced			12 Weeks";

        btnSwitchL.GetComponent<Button>().onClick.AddListener(changeTypeL);
        btnSwitchR.GetComponent<Button>().onClick.AddListener(changeTypeR);
    }

    //Functions: Changing the difficulty type
    public void changeTypeL() {
        count++;
        print("left: " + count);
    }

    public void changeTypeR() {
        if(count >= 0)
        {
            count--;
        }
        print("right: " + count);
    }

    // Update is called once per frame
    void Update() {
        if (count <= 0)
        {
            count = 0;
        }

        else if (count >= 2)
        {
            count = 2;
        }

        if(count <= 0)
        {
            btnSwitchL.GetComponent<Button>().interactable = true; //Enabling button
            btnSwitchR.GetComponent<Button>().interactable = false; //Disabling button

            panelB.SetActive(true);
            panelI.SetActive(false);
            panelA.SetActive(false);

            scrollRect.content = routineBeginner;
        }

        else if (count == 1)
        {
            btnSwitchL.GetComponent<Button>().interactable = true;
            btnSwitchR.GetComponent<Button>().interactable = true;

            panelB.SetActive(false);
            panelI.SetActive(true);
            panelA.SetActive(false);

            scrollRect.content = routineIntermediate;
        }

        else if (count >= 2)
        {
            btnSwitchL.GetComponent<Button>().interactable = false;
            btnSwitchR.GetComponent<Button>().interactable = true;

            panelB.SetActive(false);
            panelI.SetActive(false);
            panelA.SetActive(true);

            scrollRect.content = routineAdvanced;
        }


        txtDifficulty.text = difficulty[count]; //Setting difficulty
    }
}
