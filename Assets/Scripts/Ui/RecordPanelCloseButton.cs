using Assets.Scripts.Ui;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordPanelCloseButton : AbstractButton
{
    [SerializeField]
    GameObject _resordsPanel;
    public override void OnButtonClick()
    {
        _resordsPanel.SetActive(false);
    }
}
