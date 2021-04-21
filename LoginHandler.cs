using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginHandler : MonoBehaviour
{
    //Username and Password Variables
    string username;
    string password;

    string[] usernames;
    string[] passwords;

    private GameObject databaseObj;

    //Login Error Variables
    public GameObject errorPanel;
    public bool validLogin;

    // Start is called before the first frame update
    void Start()
    {
        //Creating and Initializing Arrays
        usernames = new string[3];
        passwords = new string[3];

        usernames[0] = "Puvan";
        usernames[1] = "Tom";
        usernames[2] = "Joe";

        passwords[0] = "123";
        passwords[1] = "456";
        passwords[2] = "789";

        //Finding Gameobjects during Runtime
        databaseObj = GameObject.Find("Database");

        errorPanel = GameObject.Find("ErrorPanel");

        //Set Error Panel object inactive
        if (errorPanel != null)
        {
            errorPanel.SetActive(false);
        }

        validLogin = false;
    }

    //Function: Check login credentials
    public void checkLogin() {

        if (validLogin)
        {
            SceneManager.LoadScene("HomeScene");
            DatabaseHandler.username = username; //Set username in DatabaseHandler.cs
        }

        else
        {
            openDialogueBox();
        }
    }

    //Function: Display Error 
    public void openDialogueBox() {
        errorPanel.SetActive(true); 
    }

    // Update is called once per frame
    void Update()
    {
        username = GameObject.Find("Username").GetComponent<Text>().text;
        
        password = GameObject.Find("Password").GetComponent<Text>().text;

        if (usernames.Contains(username))
        {
             if (passwords.Contains(password))
             {
                validLogin = true;
             }
            else
            {
                validLogin = false;
                LoginErrorHandler.error = "invalid Password";
            }
        }

        else
        {
            LoginErrorHandler.error = "invalid Username";
        }
  
    }
}
