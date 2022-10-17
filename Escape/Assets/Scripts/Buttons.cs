using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Buttons : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) panel.SetActive(true);
    }

    public void Escape()
    {
        Application.Quit();
    }

    public void StartG()
    {
        SceneManager.LoadScene(1);
    }

    public void StartM()
    {
        SceneManager.LoadScene(0);
    }

    public void BackGame()
    {
        panel.SetActive(false);
    }

    
}
