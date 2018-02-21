using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity;
using UnityEngine;
using UnityEngine.Playables;

namespace Halia
{
    public class OnTapAdvanceState : MonoBehaviour, IInputClickHandler, IFocusable
    {
        public const string TriggerName = "AdvanceState";

        [SerializeField] private Animator animator;
        
        public void OnInputClicked(InputClickedEventData eventData)
        {
            if (this.animator == null || !this.enabled)
                return;

            this.animator.SetTrigger(TriggerName);
        }

        public void OnFocusEnter()
        {
            InputManager.Instance.OverrideFocusedObject = gameObject;
        }

        public void OnFocusExit()
        {
            //throw new System.NotImplementedException();
        }
    }
}
