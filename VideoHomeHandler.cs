using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VideoHomeHandler : MonoBehaviour
{
    //Gameobject Variables
    public GameObject btnChest;
    public GameObject btnBack;
    public GameObject btnLegs;
    public GameObject btnAbs;

    // Start is called before the first frame update
    void Start()
    {
        //Find Gameobjects during runtime
        btnChest = GameObject.Find("Chest_Btn");
        btnBack = GameObject.Find("Back_Btn");
        btnLegs = GameObject.Find("Legs_Btn");
        btnAbs = GameObject.Find("Abs_Btn");

        btnChest.GetComponent<Button>().onClick.AddListener(changeChestExScene);
    }

    //Function: Change to ChestExScene
    public void changeChestExScene() {
        SceneManager.LoadScene("ChestExScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
