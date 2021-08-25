// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controller Scripts/PlayerControlls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControlls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControlls"",
    ""maps"": [
        {
            ""name"": ""gamePlay"",
            ""id"": ""56017009-6ac1-4fc8-8089-d13d6c43d688"",
            ""actions"": [
                {
                    ""name"": ""rollLeft"",
                    ""type"": ""Button"",
                    ""id"": ""ef7e9a8e-1538-4dbf-94c2-1b7c93f3445f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""rollRight"",
                    ""type"": ""Button"",
                    ""id"": ""1aca2571-2ecb-48b8-9a66-37a81db9d742"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""booster"",
                    ""type"": ""Button"",
                    ""id"": ""15860e12-8d3f-4b96-8492-6595ecc24c77"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""brake"",
                    ""type"": ""Button"",
                    ""id"": ""84881dea-367d-4de4-aabf-92bae965556c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""look"",
                    ""type"": ""Button"",
                    ""id"": ""08c53dd2-ff18-4252-98b4-7239cb0cb0f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3ae990c9-caa9-459d-9b7b-d784f5745c6e"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rollLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""022daaec-40a2-40b8-aca5-b7137f280676"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rollRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""969c8116-5281-4bb7-9b3e-5e64da6f51b5"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""booster"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b089bf43-c76f-4159-9177-a4500a4e919e"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""256a865b-21b3-418f-907c-29e401e11d57"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // gamePlay
        m_gamePlay = asset.FindActionMap("gamePlay", throwIfNotFound: true);
        m_gamePlay_rollLeft = m_gamePlay.FindAction("rollLeft", throwIfNotFound: true);
        m_gamePlay_rollRight = m_gamePlay.FindAction("rollRight", throwIfNotFound: true);
        m_gamePlay_booster = m_gamePlay.FindAction("booster", throwIfNotFound: true);
        m_gamePlay_brake = m_gamePlay.FindAction("brake", throwIfNotFound: true);
        m_gamePlay_look = m_gamePlay.FindAction("look", throwIfNotFound: true);
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

    // gamePlay
    private readonly InputActionMap m_gamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_gamePlay_rollLeft;
    private readonly InputAction m_gamePlay_rollRight;
    private readonly InputAction m_gamePlay_booster;
    private readonly InputAction m_gamePlay_brake;
    private readonly InputAction m_gamePlay_look;
    public struct GamePlayActions
    {
        private @PlayerControlls m_Wrapper;
        public GamePlayActions(@PlayerControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @rollLeft => m_Wrapper.m_gamePlay_rollLeft;
        public InputAction @rollRight => m_Wrapper.m_gamePlay_rollRight;
        public InputAction @booster => m_Wrapper.m_gamePlay_booster;
        public InputAction @brake => m_Wrapper.m_gamePlay_brake;
        public InputAction @look => m_Wrapper.m_gamePlay_look;
        public InputActionMap Get() { return m_Wrapper.m_gamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @rollLeft.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRollLeft;
                @rollLeft.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRollLeft;
                @rollLeft.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRollLeft;
                @rollRight.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRollRight;
                @rollRight.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRollRight;
                @rollRight.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRollRight;
                @booster.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBooster;
                @booster.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBooster;
                @booster.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBooster;
                @brake.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBrake;
                @brake.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBrake;
                @brake.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBrake;
                @look.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLook;
                @look.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLook;
                @look.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @rollLeft.started += instance.OnRollLeft;
                @rollLeft.performed += instance.OnRollLeft;
                @rollLeft.canceled += instance.OnRollLeft;
                @rollRight.started += instance.OnRollRight;
                @rollRight.performed += instance.OnRollRight;
                @rollRight.canceled += instance.OnRollRight;
                @booster.started += instance.OnBooster;
                @booster.performed += instance.OnBooster;
                @booster.canceled += instance.OnBooster;
                @brake.started += instance.OnBrake;
                @brake.performed += instance.OnBrake;
                @brake.canceled += instance.OnBrake;
                @look.started += instance.OnLook;
                @look.performed += instance.OnLook;
                @look.canceled += instance.OnLook;
            }
        }
    }
    public GamePlayActions @gamePlay => new GamePlayActions(this);
    public interface IGamePlayActions
    {
        void OnRollLeft(InputAction.CallbackContext context);
        void OnRollRight(InputAction.CallbackContext context);
        void OnBooster(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
}
