using System;
using System.Collections.Generic;
using MainScripts.ButtonScripts;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


namespace MainScripts.Controller
{
    public class ChatController : MonoBehaviour
    {
        [Header("Кнопки")] 
        [SerializeField] private ButtonScript butonSend;
        [SerializeField] private ButtonScript buttonDelete;
        [SerializeField] private TMP_InputField inputField;

        [SerializeField] private List<string> _messageList = new();
        

        void Start()
        {
            butonSend.Action += SendMessageInChat;
        }


        void Update()
        {
            buttonDelete.Action += SelectMessageInChat;
        }


        private void SendMessageInChat()
        {
            var text = inputField.text;
            inputField.text = "";
            inputField.Select();
            _messageList.Add(text);
            
        }

        private void SelectMessageInChat()
        {
            
        }
    }
}