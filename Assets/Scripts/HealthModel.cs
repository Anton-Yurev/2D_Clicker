using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthModel : MonoBehaviour
{
    public int _healthCurrent { get; private set; } = 100;
    int _healthMax;

    public void GetDamage()
    {
        _healthCurrent = _healthCurrent - 10;
    }
}
