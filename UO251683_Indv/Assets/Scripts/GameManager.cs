    using System.Collections;
    using UnityEngine;
    using UnityEngine.UI;
    using DialogueManager.GameComponents;

    public class GameManager : MonoBehaviour
    {
        int beans;
        public static GameManager inst;

        public Text beansText;
        private bool wasTriggered = false;


        public void IncrementScore()
        {
            beans++;
            beansText.text = "BEANS: " + beans;
        }

        // SINGLETON
        private void Awake()
        {
            inst = this;
        }

        void Start()
        {
            
            if (!wasTriggered)
            {
                wasTriggered = true;

                ConversationComponent conversation = this.GetComponent<ConversationComponent>();
                if (conversation != null)
                {
                    conversation.Trigger( );
                }
            }
            
        }

        void Update()
        {
            
        }
    }
