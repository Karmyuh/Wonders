using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme2 : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigid;
    float _ySpeed;


    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Duvar1"))
        {
            _ySpeed *= -1f;
        }

        if (collision.gameObject.CompareTag("Duvar2"))
        {
            
        }
    }

    private void FixedUpdate()
    {
        _rigid.velocity = new Vector2(_rigid.velocity.x, _ySpeed);
    }



    // Start is called before the first frame update
    void Start()
    {
        _ySpeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
