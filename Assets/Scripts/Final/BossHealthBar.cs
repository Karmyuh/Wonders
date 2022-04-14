using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    
    
    

    [SerializeField] static public float _maxHealth = 100, _currentHealth;
    [SerializeField] static public bool _aktifMiBoss;



    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(float health)
    {
        slider.value = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    private void Start()
    {
        _currentHealth = _maxHealth;
        SetMaxHealth(_maxHealth);
    }

    private void FixedUpdate()
    {


        
        Damage();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mermi"))
        {
            Destroy(collision.gameObject);
            _aktifMiBoss = true;
        }

        if (collision.gameObject.tag == "Arka" && collision.gameObject.tag !="Mermi")
        {
            _aktifMiBoss = false;
        }
    }

    
    public void Damage()
    {
        if (_aktifMiBoss)
        {
            _currentHealth -= 100f * Time.deltaTime;
            SetHealth(_currentHealth);
            _aktifMiBoss = false;
        }

    }
   

}
