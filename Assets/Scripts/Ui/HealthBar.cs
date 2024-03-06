using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Image _healthbarimage;
    private void Start()
    {
        _healthbarimage=GetComponent<Image>();
    }
    public void UpdateHealth(int health)
    {
        _healthbarimage.fillAmount = health/100f;
    }
}
