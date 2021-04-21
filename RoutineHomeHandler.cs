using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RoutineHomeHandler : MonoBehaviour
{
    //Gameobject variables
    public GameObject btnFatLoss;
    public GameObject btnStrength;
    public GameObject btnMuscle;
    public GameObject btnCustom;

    // Start is called before the first frame update
    void Start()
    {
        //Finding Gameobjects during runtime
        btnFatLoss = GameObject.Find("FatLoss_Button");
        btnFatLoss.GetComponent<Button>().onClick.AddListener(changeFatLossScene);
    }

    //Function: Change to FatLossScene
    public void changeFatLossScene() {
        SceneManager.LoadScene("FatLossScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
