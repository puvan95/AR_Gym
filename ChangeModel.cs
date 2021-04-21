using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeModel : MonoBehaviour {

    //Button variables
    public GameObject button;
    public Sprite maleImg;
    public Sprite femaleImg;
    public string currentModel;

    //Gameobject variables
    public GameObject maleModel;
    public GameObject femaleModel;
    public Animator animMale;
    public Animator animFemale;
    
    void Start() {

        //Set animator variables
        animMale = maleModel.GetComponent<Animator>();
        animFemale = femaleModel.GetComponent<Animator>();

        //Setting Default values
        currentModel = "Male";
        button.GetComponent<Image>().sprite = maleImg;

        maleModel.SetActive(true); //Showing male model by default
        femaleModel.SetActive(false); //Hiding female model

        animMale.SetBool("isAnimating", true);
        animFemale.SetBool("isAnimating", false);

    }

    //Function: Switch the models
    public void SwitchModels() {

        if(currentModel == "Male") //If currently Male Model, Switch to Female when button pressed
        {
            maleModel.SetActive(false);
            femaleModel.SetActive(true);

            animMale.SetBool("isAnimating", false);
            animFemale.SetBool("isAnimating", true);

            button.GetComponent<Image>().sprite = femaleImg;
            currentModel = "Female";
        }

        else if(currentModel == "Female") //If currently Female Model, Switch to Male when button pressed
        {
            maleModel.SetActive(true);
            femaleModel.SetActive(false);

            animMale.SetBool("isAnimating", true);
            animFemale.SetBool("isAnimating", false);

            button.GetComponent<Image>().sprite = maleImg;
            currentModel = "Male";
        }
        
    }
}
