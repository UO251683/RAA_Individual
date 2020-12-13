namespace DialogueManager.GameComponents.Triggers
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class KeyboardTrigger : MonoBehaviour
    {
        //NACADAS PARA PROBAR
        //public GameObject Tracked;
        private bool wasTriggered = false;

        //private Transform tPosition;

        private void Start()
        {
            //tPosition = Tracked.GetComponent<Transform>();

        }

        private void Update()
        {
            if ( Input.GetKeyDown("space")  )
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
            else if (wasTriggered)
            {
                wasTriggered = false;
            }
        }

    }
}