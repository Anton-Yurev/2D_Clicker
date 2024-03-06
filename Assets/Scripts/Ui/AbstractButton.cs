using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine;

namespace Assets.Scripts.Ui
{
    public abstract class AbstractButton : MonoBehaviour
    {
        Button _button;
        private void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(OnButtonClick);

        }

        public abstract void OnButtonClick();
    }
}
