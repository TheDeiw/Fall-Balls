using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text Scorenumber;
    [SerializeField] private Text LoseScorenumber;
    [SerializeField] private AudioSource soundBall;
    private int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {


            score = score + 1;
            Scorenumber.text = score.ToString();
            LoseScorenumber.text = score.ToString();
            soundBall.Play();
        }
    }
}
