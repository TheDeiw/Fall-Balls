using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors : MonoBehaviour
{
    [SerializeField] private Color[] ballColors;
    
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = ballColors[Random.Range(0, ballColors.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
