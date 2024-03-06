using Assets.Scripts.Ui;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordsButton : AbstractButton
{
    [SerializeField]
    GameObject _imageRecordsPanel;

    private void Start()
    {
        _imageRecordsPanel.SetActive(false);
    }
    public override void OnButtonClick()
    {
        _imageRecordsPanel.SetActive(true);
    }
}
