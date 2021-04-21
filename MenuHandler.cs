using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour {

    //Panel variables
    private GameObject menuPanel;

    //Button variables
    private GameObject btnMenu;
    private GameObject btnExit;
    private GameObject btnHome;
    private GameObject btnARCamera;
    private GameObject btnVideo;
    private GameObject btnRoutine;
    private GameObject btnLogOut;

    //Text variables
    public Text txtName;

    // Start is called before the first frame update
    void Start() {

        //Instatiate objects during runtime
        menuPanel = GameObject.Find("MenuPanel");
        btnMenu = GameObject.Find("Menu_Btn");
        btnExit = GameObject.Find("Exit_Btn");

        btnHome = GameObject.FindGameObjectWithTag("HomeBtn");
        btnARCamera = GameObject.FindGameObjectWithTag("ARBtn");
        btnVideo = GameObject.FindGameObjectWithTag("VideoBtn");
        btnRoutine = GameObject.FindGameObjectWithTag("RoutineBtn");

        btnLogOut = GameObject.FindGameObjectWithTag("LogOutBtn");


        //Default state of menu
        if (menuPanel.activeSelf)
        {
            menuPanel.SetActive(false);
        }
       
        //Adding listeners to buttons to call specific functions
        btnMenu.GetComponent<Button>().onClick.AddListener(showMenu); //Show menu
        btnExit.GetComponent<Button>().onClick.AddListener(hideMenu); //Hide menu
        btnHome.GetComponent<Button>().onClick.AddListener(changeHomeScene); //Change to Home Scene
        btnARCamera.GetComponent<Button>().onClick.AddListener(changeARScene); //Change to AR Scene
        btnVideo.GetComponent<Button>().onClick.AddListener(changeVideoScene); //Change to Video Scene
        btnRoutine.GetComponent<Button>().onClick.AddListener(changeRoutineScene); //Change to Routines Scene

        btnLogOut.GetComponent<Button>().onClick.AddListener(changeLoginScene); //Change to Routines Scene

        //Setting name using static var
        if (GameObject.Find("Name_Txt") != null)
        {
            txtName.text = DatabaseHandler.username;
        }
    }

    //Functions: Change Scenes according to buttons
    public void changeHomeScene() {
        SceneManager.LoadScene("HomeScene");
    }

    public void changeARScene() {
        SceneManager.LoadScene("ARScene");
    }

    public void changeVideoScene() {
        SceneManager.LoadScene("VideoHomeScene");
    }

    public void changeRoutineScene() {
        SceneManager.LoadScene("RoutineHomeScene");
    }

    public void changeLoginScene() {
        SceneManager.LoadScene("LoginScene");
    }

    //Functions: Open/Close side menu
    public void showMenu() {

        menuPanel.SetActive(true);
        btnMenu.SetActive(false);
    }

    public void hideMenu() {

        menuPanel.SetActive(false);
        btnMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
