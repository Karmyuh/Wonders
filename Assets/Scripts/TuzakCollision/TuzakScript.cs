using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuzakScript : MonoBehaviour
{
    [SerializeField] GameObject _ui;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            _ui.SetActive(true);
        }
    }
}
