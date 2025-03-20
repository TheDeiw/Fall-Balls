using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Destroy : MonoBehaviour
{
    [SerializeField] public GameObject obj;
    [SerializeField] public GameObject ballPS;
    

    
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Destroy"))
            {
                Destroy(obj);
               
            }

            if (other.gameObject.CompareTag("Player"))
            {
               
                Instantiate(ballPS, obj.transform.position, Quaternion.identity);
                Destroy(obj);
             
        }
    }
    

}
