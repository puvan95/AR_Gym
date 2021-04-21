using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExerciseHandler : MonoBehaviour
{
    //Button variables
    public GameObject btnSwitchR;
    public GameObject btnSwitchL;

    //Type variables
    public Text txtType;
    public int count;
    private string[] types;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        types = new string[3]; //Creating array of Type strings

        types[0] = "Normal Grip";
        types[1] = "Narrow Grip";
        types[2] = "Wide Grip";
    }

    //Functions: Change type text
    public void changeTypeL() {
        count++;
    }

    public void changeTypeR() {
        count--;
    }

    // Update is called once per frame
    void Update()
    {
        if (count < 0)
        {
            count = 0;
        }

        else if (count > 2)
        {
            count = 2;
        }

        txtType.text = types[count];
    }
}
