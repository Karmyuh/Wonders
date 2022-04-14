using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DusenTasCollider : MonoBehaviour
{

    [SerializeField] GameObject _ui;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _ui.SetActive(true);
            Time.timeScale = 0;

        }
        if (collision.gameObject.CompareTag("Tuzak"))
        {
            gameObject.SetActive(false);
            
        }
    }
}
