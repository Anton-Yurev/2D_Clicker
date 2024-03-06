using Assets.Scripts.Ui;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : AbstractButton
{
    public override void OnButtonClick()
    {
        Application.Quit();
    }
}
