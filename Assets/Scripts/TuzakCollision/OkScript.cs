using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OkScript : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _UI;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            _UI.SetActive(true);
        }
    }
}
