// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controller Scripts/SecondaryControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @SecondaryControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @SecondaryControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SecondaryControls"",
    ""maps"": [
        {
            ""name"": ""faceButtons"",
            ""id"": ""08c30c7e-66e6-427a-8011-83fdf8e4a0b9"",
            ""actions"": [
                {
                    ""name"": ""Bbutton"",
                    ""type"": ""Button"",
                    ""id"": ""8209bac8-927c-42af-95bd-0b907a4a5e7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Abutton"",
                    ""type"": ""Button"",
                    ""id"": ""cf90339a-eb7b-4fd0-8177-e4b462c16c5c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Xbutton"",
                    ""type"": ""Button"",
                    ""id"": ""6b28c410-60c5-44a4-a45f-a62fe0992033"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ybutton"",
                    ""type"": ""Button"",
                    ""id"": ""f5805c45-a1a7-4ac7-8c28-b335d6cd64c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dup"",
                    ""type"": ""Button"",
                    ""id"": ""0980d559-b53e-495d-b867-167c086e32b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dright"",
                    ""type"": ""Button"",
                    ""id"": ""656c5d6b-7d36-4681-b365-dca3464bf9f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dleft"",
                    ""type"": ""Button"",
                    ""id"": ""bbc308ff-48b6-4fa2-a9ea-ea9eb1689a74"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ddown"",
                    ""type"": ""Button"",
                    ""id"": ""48295c0f-b5db-4540-a834-47c00b84ad13"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left Stick"",
                    ""type"": ""Value"",
                    ""id"": ""2595a029-2dc6-4dfd-89ca-76794fa02096"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Stick"",
                    ""type"": ""Value"",
                    ""id"": ""1db6d0f3-b968-43d4-ad7c-be28d9a4e076"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left Stick Click"",
                    ""type"": ""Button"",
                    ""id"": ""d4436b82-fb65-4ef1-81d2-b466ee709823"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Stick Press"",
                    ""type"": ""Button"",
                    ""id"": ""2bfa7a5f-6278-44d1-a389-c6513ffa484e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BHold"",
                    ""type"": ""Button"",
                    ""id"": ""7dfad647-3af2-4158-a17d-350247f7a62a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""82534483-59b7-409c-a841-cd4cb4a01c98"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bbutton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00356bdd-1275-443c-bf63-b42fafd8f377"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Abutton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d2fd112-b667-4375-840f-a435fa13a60f"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Xbutton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06a0ef6f-67e5-48ad-8d6f-bcc2ca01858d"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ybutton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1dcb811-7659-4ed1-8f10-330ba55b1fc1"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a07d054a-f1de-4369-9c55-00b59e9182c7"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dright"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7241b78e-9f1c-4404-8e50-209fb62a05b8"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dleft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8194345-ff8d-4709-b5b1-631f08d594cb"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ddown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""057dbf9c-efed-4154-a9d1-fd4e317b3da3"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a867a918-bf7f-449b-b702-75f60631db9a"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9c04813-8014-44b4-b778-6c6202296b57"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Stick Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6738b3e-ca5d-4197-a9ad-ebd74ad30a1a"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Stick Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be08fe9f-b335-42b3-9a97-88b69e891d9f"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // faceButtons
        m_faceButtons = asset.FindActionMap("faceButtons", throwIfNotFound: true);
        m_faceButtons_Bbutton = m_faceButtons.FindAction("Bbutton", throwIfNotFound: true);
        m_faceButtons_Abutton = m_faceButtons.FindAction("Abutton", throwIfNotFound: true);
        m_faceButtons_Xbutton = m_faceButtons.FindAction("Xbutton", throwIfNotFound: true);
        m_faceButtons_Ybutton = m_faceButtons.FindAction("Ybutton", throwIfNotFound: true);
        m_faceButtons_Dup = m_faceButtons.FindAction("Dup", throwIfNotFound: true);
        m_faceButtons_Dright = m_faceButtons.FindAction("Dright", throwIfNotFound: true);
        m_faceButtons_Dleft = m_faceButtons.FindAction("Dleft", throwIfNotFound: true);
        m_faceButtons_Ddown = m_faceButtons.FindAction("Ddown", throwIfNotFound: true);
        m_faceButtons_LeftStick = m_faceButtons.FindAction("Left Stick", throwIfNotFound: true);
        m_faceButtons_RightStick = m_faceButtons.FindAction("Right Stick", throwIfNotFound: true);
        m_faceButtons_LeftStickClick = m_faceButtons.FindAction("Left Stick Click", throwIfNotFound: true);
        m_faceButtons_RightStickPress = m_faceButtons.FindAction("Right Stick Press", throwIfNotFound: true);
        m_faceButtons_BHold = m_faceButtons.FindAction("BHold", throwIfNotFound: true);
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

    // faceButtons
    private readonly InputActionMap m_faceButtons;
    private IFaceButtonsActions m_FaceButtonsActionsCallbackInterface;
    private readonly InputAction m_faceButtons_Bbutton;
    private readonly InputAction m_faceButtons_Abutton;
    private readonly InputAction m_faceButtons_Xbutton;
    private readonly InputAction m_faceButtons_Ybutton;
    private readonly InputAction m_faceButtons_Dup;
    private readonly InputAction m_faceButtons_Dright;
    private readonly InputAction m_faceButtons_Dleft;
    private readonly InputAction m_faceButtons_Ddown;
    private readonly InputAction m_faceButtons_LeftStick;
    private readonly InputAction m_faceButtons_RightStick;
    private readonly InputAction m_faceButtons_LeftStickClick;
    private readonly InputAction m_faceButtons_RightStickPress;
    private readonly InputAction m_faceButtons_BHold;
    public struct FaceButtonsActions
    {
        private @SecondaryControls m_Wrapper;
        public FaceButtonsActions(@SecondaryControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Bbutton => m_Wrapper.m_faceButtons_Bbutton;
        public InputAction @Abutton => m_Wrapper.m_faceButtons_Abutton;
        public InputAction @Xbutton => m_Wrapper.m_faceButtons_Xbutton;
        public InputAction @Ybutton => m_Wrapper.m_faceButtons_Ybutton;
        public InputAction @Dup => m_Wrapper.m_faceButtons_Dup;
        public InputAction @Dright => m_Wrapper.m_faceButtons_Dright;
        public InputAction @Dleft => m_Wrapper.m_faceButtons_Dleft;
        public InputAction @Ddown => m_Wrapper.m_faceButtons_Ddown;
        public InputAction @LeftStick => m_Wrapper.m_faceButtons_LeftStick;
        public InputAction @RightStick => m_Wrapper.m_faceButtons_RightStick;
        public InputAction @LeftStickClick => m_Wrapper.m_faceButtons_LeftStickClick;
        public InputAction @RightStickPress => m_Wrapper.m_faceButtons_RightStickPress;
        public InputAction @BHold => m_Wrapper.m_faceButtons_BHold;
        public InputActionMap Get() { return m_Wrapper.m_faceButtons; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FaceButtonsActions set) { return set.Get(); }
        public void SetCallbacks(IFaceButtonsActions instance)
        {
            if (m_Wrapper.m_FaceButtonsActionsCallbackInterface != null)
            {
                @Bbutton.started -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnBbutton;
                @Bbutton.performed -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnBbutton;
                @Bbutton.canceled -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnBbutton;
                @Abutton.started -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnAbutton;
                @Abutton.performed -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnAbutton;
                @Abutton.canceled -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnAbutton;
                @Xbutton.started -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnXbutton;
                @Xbutton.performed -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnXbutton;
                @Xbutton.canceled -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnXbutton;
                @Ybutton.started -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnYbutton;
                @Ybutton.performed -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnYbutton;
                @Ybutton.canceled -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnYbutton;
                @Dup.started -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnDup;
                @Dup.performed -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnDup;
                @Dup.canceled -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnDup;
                @Dright.started -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnDright;
                @Dright.performed -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnDright;
                @Dright.canceled -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnDright;
                @Dleft.started -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnDleft;
                @Dleft.performed -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnDleft;
                @Dleft.canceled -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnDleft;
                @Ddown.started -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnDdown;
                @Ddown.performed -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnDdown;
                @Ddown.canceled -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnDdown;
                @LeftStick.started -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnLeftStick;
                @LeftStick.performed -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnLeftStick;
                @LeftStick.canceled -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnLeftStick;
                @RightStick.started -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnRightStick;
                @RightStick.performed -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnRightStick;
                @RightStick.canceled -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnRightStick;
                @LeftStickClick.started -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnLeftStickClick;
                @LeftStickClick.performed -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnLeftStickClick;
                @LeftStickClick.canceled -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnLeftStickClick;
                @RightStickPress.started -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnRightStickPress;
                @RightStickPress.performed -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnRightStickPress;
                @RightStickPress.canceled -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnRightStickPress;
                @BHold.started -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnBHold;
                @BHold.performed -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnBHold;
                @BHold.canceled -= m_Wrapper.m_FaceButtonsActionsCallbackInterface.OnBHold;
            }
            m_Wrapper.m_FaceButtonsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Bbutton.started += instance.OnBbutton;
                @Bbutton.performed += instance.OnBbutton;
                @Bbutton.canceled += instance.OnBbutton;
                @Abutton.started += instance.OnAbutton;
                @Abutton.performed += instance.OnAbutton;
                @Abutton.canceled += instance.OnAbutton;
                @Xbutton.started += instance.OnXbutton;
                @Xbutton.performed += instance.OnXbutton;
                @Xbutton.canceled += instance.OnXbutton;
                @Ybutton.started += instance.OnYbutton;
                @Ybutton.performed += instance.OnYbutton;
                @Ybutton.canceled += instance.OnYbutton;
                @Dup.started += instance.OnDup;
                @Dup.performed += instance.OnDup;
                @Dup.canceled += instance.OnDup;
                @Dright.started += instance.OnDright;
                @Dright.performed += instance.OnDright;
                @Dright.canceled += instance.OnDright;
                @Dleft.started += instance.OnDleft;
                @Dleft.performed += instance.OnDleft;
                @Dleft.canceled += instance.OnDleft;
                @Ddown.started += instance.OnDdown;
                @Ddown.performed += instance.OnDdown;
                @Ddown.canceled += instance.OnDdown;
                @LeftStick.started += instance.OnLeftStick;
                @LeftStick.performed += instance.OnLeftStick;
                @LeftStick.canceled += instance.OnLeftStick;
                @RightStick.started += instance.OnRightStick;
                @RightStick.performed += instance.OnRightStick;
                @RightStick.canceled += instance.OnRightStick;
                @LeftStickClick.started += instance.OnLeftStickClick;
                @LeftStickClick.performed += instance.OnLeftStickClick;
                @LeftStickClick.canceled += instance.OnLeftStickClick;
                @RightStickPress.started += instance.OnRightStickPress;
                @RightStickPress.performed += instance.OnRightStickPress;
                @RightStickPress.canceled += instance.OnRightStickPress;
                @BHold.started += instance.OnBHold;
                @BHold.performed += instance.OnBHold;
                @BHold.canceled += instance.OnBHold;
            }
        }
    }
    public FaceButtonsActions @faceButtons => new FaceButtonsActions(this);
    public interface IFaceButtonsActions
    {
        void OnBbutton(InputAction.CallbackContext context);
        void OnAbutton(InputAction.CallbackContext context);
        void OnXbutton(InputAction.CallbackContext context);
        void OnYbutton(InputAction.CallbackContext context);
        void OnDup(InputAction.CallbackContext context);
        void OnDright(InputAction.CallbackContext context);
        void OnDleft(InputAction.CallbackContext context);
        void OnDdown(InputAction.CallbackContext context);
        void OnLeftStick(InputAction.CallbackContext context);
        void OnRightStick(InputAction.CallbackContext context);
        void OnLeftStickClick(InputAction.CallbackContext context);
        void OnRightStickPress(InputAction.CallbackContext context);
        void OnBHold(InputAction.CallbackContext context);
    }
}
