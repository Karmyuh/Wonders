using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    static int _score;
    [SerializeField] Text _scoreText;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Meteor"))
        {
            
            Debug.Log("Çalýstý");


        }
    }
    





    private void Update()
    {
        
    }


}
