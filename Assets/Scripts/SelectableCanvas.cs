using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CustomUINavigation
{
    [RequireComponent(typeof(Canvas))]
    public class SelectableCanvas : MonoBehaviour
    {
        private static SelectableCanvas[] SelectableCanvases;

        private void OnEnable()
        {
            SelectableCanvases = FindObjectsOfType<SelectableCanvas>();
        }
    }
}