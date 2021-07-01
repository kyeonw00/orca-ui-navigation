using UnityEngine;
using UnityEngine.UI;

namespace CustomUINavigation
{
    public class SelectableGrid : MonoBehaviour
    {
        private GridLayoutGroup _gridLayoutGroup;

        private void Awake()
        {
            if (!TryGetComponent<GridLayoutGroup>(out _gridLayoutGroup))
                Debug.LogWarning("Cannot parse a component type of <color=green>GridLayoutGroup</color>");
        }
    }
}