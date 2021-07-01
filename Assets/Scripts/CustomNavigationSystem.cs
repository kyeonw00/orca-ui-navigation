using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace CustomUINavigation
{
    public class CustomNavigationSystem : MonoBehaviour
    {
        public static CustomNavigationSystem Current;

        public Selectable defaultSelectable;

        public Selectable currentSelected;

        private void Awake()
        {
            if (Current != null)
            {
                Destroy(gameObject);
                return;
            }

            Current = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}