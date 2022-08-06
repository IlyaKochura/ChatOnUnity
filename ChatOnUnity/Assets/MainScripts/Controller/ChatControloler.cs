using MainScripts.ButtonScripts;
using UnityEngine;


namespace MainScripts.Controller
{
    public class ChatControloler : MonoBehaviour
    {
        [Header("Кнопки")] 
        [SerializeField] private ButtonScript butonSend;
        [SerializeField] private ButtonScript buttonDelete;
        [SerializeField] private ButtonScript _buttonScript;
        


        void Start()
        {
        }


        void Update()
        {
        }
    }
}