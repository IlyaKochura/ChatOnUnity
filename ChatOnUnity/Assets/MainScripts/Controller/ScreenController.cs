using System;
using System.Collections.Generic;
using MainScripts.ButtonScripts;
using MainScripts.View;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


namespace MainScripts.Controller
{
    public class ScreenController : MonoBehaviour
    { 
        [SerializeField] private List<MyMessageView> _mainMessageList = new();
        private List<string> _user1MessageList = new();
        private List<string> _user2MessageList = new();
        [SerializeField] private HoodView hoodView;
        [SerializeField] private MyMessageView myMessagePrefab;
        [SerializeField] private VerticalLayoutGroup scrollMessage;
        
        void Start()
        {
            
        }


        void Update()
        {
            hoodView.sendButton.Action += SendMessageInChat;
        }


        private void SendMessageInChat()
        {
            var text = hoodView.inputField.text;
            if (string.IsNullOrWhiteSpace(text)) return;
            var message = Instantiate(myMessagePrefab, scrollMessage.transform);
            message.messageText.text = text;
            hoodView.inputField.text = "";
            hoodView.inputField.Select();
            _mainMessageList.Add(message);
        }

        private void SelectMessageInChat()
        {
            
        }
    }
}