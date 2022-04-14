using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartScripts : MonoBehaviour
{
    public bool _aktifMi;
    

    public void RestartButon()
    {
        SceneManager.LoadScene(0);
        Time.timeScale=1;

    }
    public void RestartButon1()
    {
        _aktifMi = true;
        
        SceneManager.LoadScene(3);
        EnemyShipCollision._aktifMi2 = false;
        //BossFireCollider._aktifMi3 = false;
        MetoerCollision._aktifMi = false;
        Mermi1Collider._aktifMiMermi1 = false;
        BossHealthBar._aktifMiBoss = false;
        Time.timeScale = 1;
        

    }
  
    public void RestartButon2()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;

    }

    private void Start()
    {
        _aktifMi = false;
    }

}
