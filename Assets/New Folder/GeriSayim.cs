using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeriSayim : MonoBehaviour
{
    [SerializeField] float _currentTime;
    [SerializeField] float _oyunS�resi;
    [SerializeField] GameObject _meteorSpawner, _enemySpawner;

    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;
        Sayim();
    }

    void Sayim()
    {


        if (_currentTime >_oyunS�resi)
        {
            _meteorSpawner.SetActive(false);
            _enemySpawner.SetActive(false);
        }
    }
}
