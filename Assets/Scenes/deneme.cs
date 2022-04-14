using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deneme : MonoBehaviour
{
    float _directionX,_moveSpeed;
    Rigidbody2D _rigid;
    bool facingRight = false;
    Vector3 localScale;

    private void Start()
    {
        localScale = transform.localScale;
        _rigid = GetComponent<Rigidbody2D>();
        _directionX = -1f;
        _moveSpeed = 3f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent <Wall> ())
        {
            _directionX *= -1f;
        }
    }

    private void FixedUpdate()
    {
        _rigid.velocity = new Vector2(_directionX * _moveSpeed, _rigid.velocity.y);
    }

    void CheckWhereToFace()
    {
        if (_directionX>0)
        {
            facingRight = true;
        }

        else if (_directionX <0)
        {
            facingRight = false;
        }

        if (((facingRight)&&(localScale.x<0)) || ((!facingRight) && (localScale.x>0)))
        {
            localScale.x *= -1;

            transform.localScale = localScale;
        }
    }

    private void LateUpdate()
    {
        CheckWhereToFace();
    }
}
