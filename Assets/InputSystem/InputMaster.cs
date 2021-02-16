// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""CharacterMoving"",
            ""id"": ""85efcf92-e458-4f40-9ea6-025020447e54"",
            ""actions"": [
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""a5a02970-c484-4f21-889a-36cf01548f3f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""22e6cef8-db1f-4890-b91c-1b44c1261caa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7ee362d7-074d-4266-8ff1-f91b28376c46"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96d705f8-b06e-4394-b1c5-24b4e4c8c8a6"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""KeyboardMoving"",
                    ""id"": ""46ab0c19-65e2-4506-93ac-26cae731c966"",
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
                    ""id"": ""104dfb07-44b1-48b4-ba23-5259bf8073cd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8f47a925-eb69-466d-af66-7a6b548710e3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b53cb4ba-c6ce-4e95-96fc-c1116bede455"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e1c82da3-3dbc-4acd-8d82-02c49f2ebd2f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""GamepadMoving"",
                    ""id"": ""f6b3e261-6921-4674-967d-2d0976e7ae0e"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""18777d0a-58c6-452c-b8a8-0ae1b3996192"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8235e490-67d6-4561-bb91-527c75238ee6"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e79a64f6-be2e-4819-befc-dedd0e21578c"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a60f0e1f-a24f-4eb9-b5d5-28673e7681b3"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardAndMouse"",
            ""bindingGroup"": ""KeyboardAndMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // CharacterMoving
        m_CharacterMoving = asset.FindActionMap("CharacterMoving", throwIfNotFound: true);
        m_CharacterMoving_Use = m_CharacterMoving.FindAction("Use", throwIfNotFound: true);
        m_CharacterMoving_Movement = m_CharacterMoving.FindAction("Movement", throwIfNotFound: true);
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

    // CharacterMoving
    private readonly InputActionMap m_CharacterMoving;
    private ICharacterMovingActions m_CharacterMovingActionsCallbackInterface;
    private readonly InputAction m_CharacterMoving_Use;
    private readonly InputAction m_CharacterMoving_Movement;
    public struct CharacterMovingActions
    {
        private @InputMaster m_Wrapper;
        public CharacterMovingActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Use => m_Wrapper.m_CharacterMoving_Use;
        public InputAction @Movement => m_Wrapper.m_CharacterMoving_Movement;
        public InputActionMap Get() { return m_Wrapper.m_CharacterMoving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterMovingActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterMovingActions instance)
        {
            if (m_Wrapper.m_CharacterMovingActionsCallbackInterface != null)
            {
                @Use.started -= m_Wrapper.m_CharacterMovingActionsCallbackInterface.OnUse;
                @Use.performed -= m_Wrapper.m_CharacterMovingActionsCallbackInterface.OnUse;
                @Use.canceled -= m_Wrapper.m_CharacterMovingActionsCallbackInterface.OnUse;
                @Movement.started -= m_Wrapper.m_CharacterMovingActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CharacterMovingActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CharacterMovingActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_CharacterMovingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Use.started += instance.OnUse;
                @Use.performed += instance.OnUse;
                @Use.canceled += instance.OnUse;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public CharacterMovingActions @CharacterMoving => new CharacterMovingActions(this);
    private int m_KeyboardAndMouseSchemeIndex = -1;
    public InputControlScheme KeyboardAndMouseScheme
    {
        get
        {
            if (m_KeyboardAndMouseSchemeIndex == -1) m_KeyboardAndMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardAndMouse");
            return asset.controlSchemes[m_KeyboardAndMouseSchemeIndex];
        }
    }
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    public interface ICharacterMovingActions
    {
        void OnUse(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
    }
}
