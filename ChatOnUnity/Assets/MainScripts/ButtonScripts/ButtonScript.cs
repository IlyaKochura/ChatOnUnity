using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MainScripts.ButtonScripts
{
    public class ButtonScript : MonoBehaviour
        {
            private Button _button;
            public Action Action { get; set; }
            
            void Start()
            {
                _button = GetComponent<Button>();
                _button.onClick.AddListener(() => Action?.Invoke());
            }

            public void SetText(string text)
            {
                gameObject.GetComponentInChildren<TextMeshProUGUI>().text = text;
            }
        }
}