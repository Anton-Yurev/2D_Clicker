using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using BallClicker;

public class HealthController : MonoBehaviour
{
    [SerializeField]
    HealthBar healthBar;
    [SerializeField]
    HealthModel healthModel;

    private void OnEnable()
    {
        ZoneLose.OnBallInLoss += ChageHealthBar;
    }
    private void OnDisable()
    {
        ZoneLose.OnBallInLoss -= ChageHealthBar;
    }
    void ChageHealthBar()
    {
        healthModel.GetDamage();
        if (healthModel._healthCurrent <= 0) 
        {
            GameOver();
        }
        healthBar.UpdateHealth(healthModel._healthCurrent);
    }
    void GameOver()
    {
        SceneManager.LoadScene(0);
    }
}
