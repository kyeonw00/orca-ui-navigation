// GENERATED AUTOMATICALLY FROM 'Assets/Resources/InputAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace CustomUINavigation
{
    public class @CustomInpuAction : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @CustomInpuAction()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputAction"",
    ""maps"": [
        {
            ""name"": ""UI"",
            ""id"": ""3a0833ef-01ea-4aae-b92e-6e77f4a2f43f"",
            ""actions"": [
                {
                    ""name"": ""AxisInput"",
                    ""type"": ""Value"",
                    ""id"": ""1a73ba8f-9b6a-4554-b00a-41ff500440b9"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": ""AxisDeadzone,NormalizeVector2"",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""SubmitInput"",
                    ""type"": ""Button"",
                    ""id"": ""d6a25d92-d7e3-4fd1-b827-099f783a23a2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0b6e3b43-4413-410d-b84b-152a4c3744d8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxisInput"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c9a45aff-e7c8-4c08-85cb-b53e867c87b9"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxisInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e4ee8198-f379-4531-850a-33ccb3109d2f"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxisInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""09696333-623a-4898-a915-cdbbe8e6da9d"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxisInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b7fb53e6-dd45-40fb-9431-4a6b96c42688"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AxisInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""508bd1a7-4ecf-40a8-844e-c0bedb7ff6df"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SubmitInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // UI
            m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
            m_UI_AxisInput = m_UI.FindAction("AxisInput", throwIfNotFound: true);
            m_UI_SubmitInput = m_UI.FindAction("SubmitInput", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // UI
        private readonly InputActionMap m_UI;
        private IUIActions m_UIActionsCallbackInterface;
        private readonly InputAction m_UI_AxisInput;
        private readonly InputAction m_UI_SubmitInput;
        public struct UIActions
        {
            private @CustomInpuAction m_Wrapper;
            public UIActions(@CustomInpuAction wrapper) { m_Wrapper = wrapper; }
            public InputAction @AxisInput => m_Wrapper.m_UI_AxisInput;
            public InputAction @SubmitInput => m_Wrapper.m_UI_SubmitInput;
            public InputActionMap Get() { return m_Wrapper.m_UI; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
            public void SetCallbacks(IUIActions instance)
            {
                if (m_Wrapper.m_UIActionsCallbackInterface != null)
                {
                    @AxisInput.started -= m_Wrapper.m_UIActionsCallbackInterface.OnAxisInput;
                    @AxisInput.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnAxisInput;
                    @AxisInput.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnAxisInput;
                    @SubmitInput.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmitInput;
                    @SubmitInput.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmitInput;
                    @SubmitInput.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmitInput;
                }
                m_Wrapper.m_UIActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @AxisInput.started += instance.OnAxisInput;
                    @AxisInput.performed += instance.OnAxisInput;
                    @AxisInput.canceled += instance.OnAxisInput;
                    @SubmitInput.started += instance.OnSubmitInput;
                    @SubmitInput.performed += instance.OnSubmitInput;
                    @SubmitInput.canceled += instance.OnSubmitInput;
                }
            }
        }
        public UIActions @UI => new UIActions(this);
        public interface IUIActions
        {
            void OnAxisInput(InputAction.CallbackContext context);
            void OnSubmitInput(InputAction.CallbackContext context);
        }
    }
}
