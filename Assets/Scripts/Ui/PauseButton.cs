using Assets.Scripts.Ui;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : AbstractButton
{
    public static Action OnPause = delegate { };
    bool IsPause = false;
    [SerializeField]
    Image _imagePause;
    [SerializeField]
    Image _imagePlay;
    private void Start()
    {
        _imagePlay.enabled = false;
    }
    void Pause()
    {
        OnPause();
        if (!IsPause)
        {
            Time.timeScale = 0;
            _imagePause.enabled = false;
            _imagePlay.enabled = true;
            IsPause = true;
        }
        else
        {
            Time.timeScale = 1;
            _imagePause.enabled = true;
            _imagePlay.enabled = false;
            IsPause = false;
        }
    }

    public override void OnButtonClick()
    {
        Pause();
    }
}
