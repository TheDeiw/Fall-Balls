using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hp : MonoBehaviour
{
    [SerializeField] private Text Hnumber;
    int health = 22;
    [SerializeField] GameObject losepanel;
    private void OnTriggerEnter(Collider other)
    {
        health = health - 1;
        Hnumber.text = health.ToString();
    }

     void Update()
    {
        if (health == 0)
        {
            losepanel.SetActive(true);
            Time.timeScale = 0;
            health = 1;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void NewGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);

    }
}
