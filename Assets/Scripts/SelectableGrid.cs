using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

namespace CustomUINavigation
{
    [RequireComponent(typeof(GridLayoutGroup))]
    public class SelectableGrid : MonoBehaviour
    {
        public Vector3 axisInput;
        public GridLayoutGroup gridLayoutGroup;
        public CustomSelectable prefab;

        private CustomInpuAction _customInputAction;
        private CustomSelectable[] _availableSelectables;
        private CustomSelectable _currentSelectable;

        public void Awake()
        {
            _customInputAction = new CustomInpuAction();
            _customInputAction.UI.AxisInput.performed += OnAxisInput;
            _customInputAction.UI.SubmitInput.performed += OnSubmitInput;
            _customInputAction.Enable();

            for (int i = 0; i < 18; i++)
            {
                Instantiate(prefab, transform);
            }

            gridLayoutGroup = GetComponent<GridLayoutGroup>();
            _availableSelectables = GetComponentsInChildren<CustomSelectable>();
        }

        private void OnAxisInput(InputAction.CallbackContext context)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            Vector2 inputAxis = context.ReadValue<Vector2>();

            if (_currentSelectable == null)
            {
                _currentSelectable = _availableSelectables[0];
            }
            else
            {
                _currentSelectable.OnDeselect(eventData);
                CustomSelectable newSelectable = (CustomSelectable) _currentSelectable.FindSelectable(inputAxis);

                if (newSelectable == null)
                {
                    Vector2 oppositeDir = inputAxis * -1;
                    newSelectable = _currentSelectable;
                    while (true)
                    {
                        CustomSelectable oppositeDirSelectable = (CustomSelectable) newSelectable.FindSelectable(oppositeDir);

                        if (oppositeDirSelectable == null)
                        {
                            break;
                        }

                        newSelectable = oppositeDirSelectable;
                    }
                }

                _currentSelectable = newSelectable;
            }

            if (_currentSelectable == null)
            {
            }

            _currentSelectable?.OnSelect(new BaseEventData(EventSystem.current));
        }
        
        private void OnSubmitInput(InputAction.CallbackContext context)
        {
            Debug.Log("Submit Input");
            _currentSelectable?.OnPointerDown(new PointerEventData(EventSystem.current));
        }
    }
}