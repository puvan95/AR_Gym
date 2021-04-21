using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContinueScene : MonoBehaviour
{
    //Gameobject Variables
    public GameObject continueBtn;

    // Start is called before the first frame update
    void Start()
    {
        //Finding gameobject during runtime
        continueBtn = GameObject.Find("Continue_Btn");

        continueBtn.GetComponent<Button>().onClick.AddListener(changeLoginScene);
    }

    //Function: Change to LoginScene
    public void changeLoginScene() {
        SceneManager.LoadScene("LoginScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
