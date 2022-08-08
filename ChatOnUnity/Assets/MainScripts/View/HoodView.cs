using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using MainScripts.ButtonScripts;
using TMPro;
using UnityEngine;

namespace MainScripts.View
{
    public class HoodView : MonoBehaviour
    {
        [CanBeNull] public ButtonScript sendButton;
        [CanBeNull] public ButtonScript deleteButton;
        [CanBeNull] public TMP_InputField inputField;
        [CanBeNull] public Action Action;
        

        public void SetText(string text)
        {
            inputField.text = text;
        }
    }
}