//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Mitchel's stuff/Input/InputMaster.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputMaster : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""e837d385-946d-4fac-a601-99030e23b83e"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ce4931dd-d2a8-468d-b3cd-941e101837cd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cam"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6846efcf-ed53-4249-af07-8fc2b58f0554"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""d60ef893-b2dc-4afc-b56d-7e0be89bbe37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SprintStart"",
                    ""type"": ""Button"",
                    ""id"": ""50daf4d5-8a0d-4df4-9534-9e45a5d6221a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShopTab"",
                    ""type"": ""Value"",
                    ""id"": ""12d0a3dd-8aee-49fb-8fec-12b227b1bc3e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PauseEsc"",
                    ""type"": ""Value"",
                    ""id"": ""941b044b-9890-4a5d-a07f-f87337ff9c23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""WaveStarter"",
                    ""type"": ""Value"",
                    ""id"": ""a31b4d99-4178-45c4-88c8-86adb28de074"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD Walk"",
                    ""id"": ""fd33c08e-338a-4654-8ce3-e143fc933369"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0effd200-32b8-4b25-b633-10fb9f4c0408"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""127536b5-5a14-45c4-9bef-55e8d6e0327c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1fd0b9a6-5f6d-4825-af0f-3c3cf81e83b3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""62ae4d5d-cf29-4cb2-b862-a7ed3f3b28e7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""346b01a5-9972-4990-993b-ac3fce6a56f6"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0276156f-cf92-4107-a21e-3ef25f155486"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba6acaf0-1302-4306-bb35-cc5c3d9c815c"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SprintStart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1656ddc5-cf0d-479f-8513-a14688425a60"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseEsc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92322cbb-2090-4830-92f7-8fb5d2ade626"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShopTab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ec4de8a-96b2-4a77-8a31-9b7b0494b5aa"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WaveStarter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Cam = m_Player.FindAction("Cam", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_SprintStart = m_Player.FindAction("SprintStart", throwIfNotFound: true);
        m_Player_ShopTab = m_Player.FindAction("ShopTab", throwIfNotFound: true);
        m_Player_PauseEsc = m_Player.FindAction("PauseEsc", throwIfNotFound: true);
        m_Player_WaveStarter = m_Player.FindAction("WaveStarter", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Cam;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_SprintStart;
    private readonly InputAction m_Player_ShopTab;
    private readonly InputAction m_Player_PauseEsc;
    private readonly InputAction m_Player_WaveStarter;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Cam => m_Wrapper.m_Player_Cam;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @SprintStart => m_Wrapper.m_Player_SprintStart;
        public InputAction @ShopTab => m_Wrapper.m_Player_ShopTab;
        public InputAction @PauseEsc => m_Wrapper.m_Player_PauseEsc;
        public InputAction @WaveStarter => m_Wrapper.m_Player_WaveStarter;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Cam.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCam;
                @Cam.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCam;
                @Cam.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCam;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @SprintStart.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprintStart;
                @SprintStart.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprintStart;
                @SprintStart.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprintStart;
                @ShopTab.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShopTab;
                @ShopTab.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShopTab;
                @ShopTab.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShopTab;
                @PauseEsc.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseEsc;
                @PauseEsc.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseEsc;
                @PauseEsc.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPauseEsc;
                @WaveStarter.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWaveStarter;
                @WaveStarter.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWaveStarter;
                @WaveStarter.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWaveStarter;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Cam.started += instance.OnCam;
                @Cam.performed += instance.OnCam;
                @Cam.canceled += instance.OnCam;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @SprintStart.started += instance.OnSprintStart;
                @SprintStart.performed += instance.OnSprintStart;
                @SprintStart.canceled += instance.OnSprintStart;
                @ShopTab.started += instance.OnShopTab;
                @ShopTab.performed += instance.OnShopTab;
                @ShopTab.canceled += instance.OnShopTab;
                @PauseEsc.started += instance.OnPauseEsc;
                @PauseEsc.performed += instance.OnPauseEsc;
                @PauseEsc.canceled += instance.OnPauseEsc;
                @WaveStarter.started += instance.OnWaveStarter;
                @WaveStarter.performed += instance.OnWaveStarter;
                @WaveStarter.canceled += instance.OnWaveStarter;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCam(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnSprintStart(InputAction.CallbackContext context);
        void OnShopTab(InputAction.CallbackContext context);
        void OnPauseEsc(InputAction.CallbackContext context);
        void OnWaveStarter(InputAction.CallbackContext context);
    }
}
