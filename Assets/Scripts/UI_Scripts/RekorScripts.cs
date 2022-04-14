using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RekorScripts : MonoBehaviour
{
    [SerializeField] GameObject _kupaImage;
    [SerializeField] Text _text;
    public void KupaGetir()
    {
        _text.text = PlayerPrefs.GetString("NickName") +" = "+ PlayerPrefs.GetInt("Scor");
        
        _kupaImage.SetActive(true);

    }


}
