using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseHandler : MonoBehaviour
{
    public static string username; //Stores the username that is logged in

    private void Awake() {
        DontDestroyOnLoad(gameObject); //Keeps the object alive in the next scene
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
