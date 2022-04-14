using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    public int _skor1, _skor2,_skor3,_toplamSkor;


    private void FixedUpdate()
    {
        //_skor1 = MetoerCollision._scoree;
        //_skor2 = EnemyShipCollision._score2;
        //_skor3 = BossFireCollider._scoreee;
        _toplamSkor = _skor1 + _skor2 + _skor3;
    }
    private void Update()
    {

        _scoreText.text = "Score : " + " " + (_toplamSkor).ToString();
        VeriGonder();
       
    }

    private void Start()
    {
        _toplamSkor = PlayerPrefs.GetInt("Sonuc"); 
        
    }

    void VeriGonder()
    {
        PlayerPrefs.SetInt("Sonuc", _toplamSkor);
    }

    void ScorTut()
    {
        PlayerPrefs.SetInt("Scor",_toplamSkor); 
    }
}
