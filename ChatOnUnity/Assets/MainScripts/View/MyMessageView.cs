using System.Collections;
using System.Collections.Generic;
using MainScripts.ButtonScripts;
using TMPro;
using UnityEngine;


namespace MainScripts.View
{
    public class MyMessageView : MonoBehaviour
    {
        public ButtonScript deleteButton;
        public TMP_InputField messageText;


        public void SetTextInMessage(string text)
        {
            messageText.text = text;
        }

    }
}