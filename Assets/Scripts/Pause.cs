using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField]
    public GameObject panel;

     void Start()
    {
        panel.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

        public void PausedOff()
        {
            Time.timeScale = 1f;
            panel.SetActive(false);
        }

        public void Menu()
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1f;
        }
    
   
   

}
