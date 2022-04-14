using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavScript : MonoBehaviour
{
    [SerializeField] GameObject _ui;
    [SerializeField] GameObject _boss;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            _ui.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Dusman"))
        {
            Destroy(_boss);
        }
    }
}
