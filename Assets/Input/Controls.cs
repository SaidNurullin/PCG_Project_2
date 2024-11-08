//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Input/Controls.inputactions
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

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""bd960b93-17e5-4908-a885-ca419be41f44"",
            ""actions"": [
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Value"",
                    ""id"": ""93a450ca-c2f3-413f-9310-748605b156c2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""48c60dc0-c60f-4abd-9f5f-71f8c1c807e6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""990c0c85-d45a-4980-a7af-277317a0c4de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""06e5a668-4de4-428e-b0e9-426f8839bb88"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""adf36040-668e-4699-bbd9-0d1943d5b33c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""18e77993-5312-405c-b4bb-6f976c2a46eb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""561ca09f-9038-48d6-9456-34f5d69fda51"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""67a05493-a947-4809-bb08-9b04f566b1a4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a3b189c0-4e9a-47bb-be83-5798ed199272"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fc8291d9-ad3a-452c-b1f2-b88abea10c8d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c84a7a11-d176-4333-bc87-509f66f6d923"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8db4742-7dae-4595-9d4c-da7efbc17bcf"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""9dd69edf-5b69-4de5-b0d1-3d1ae6aee285"",
            ""actions"": [
                {
                    ""name"": ""X_axis"",
                    ""type"": ""Value"",
                    ""id"": ""a19e4f08-cc5a-4e5a-b434-3453c87368b2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Y_axis"",
                    ""type"": ""Value"",
                    ""id"": ""e9cb6299-de9d-4edb-9da0-10e8bc3fc886"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""28d0b446-f790-4163-ad6e-1bf3552c8b76"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X_axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b199e8a4-3ddb-4a24-a499-16aad3bf4abc"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y_axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Hand"",
            ""id"": ""e6970cfc-ce18-4b9e-a65c-36a30305821f"",
            ""actions"": [
                {
                    ""name"": ""Slot1"",
                    ""type"": ""Button"",
                    ""id"": ""f701331d-a9c9-4651-88ba-a63bfd860a9d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Slot2"",
                    ""type"": ""Button"",
                    ""id"": ""73a0fe98-7eb2-4b9a-ae6d-53112d8f720d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Slot3"",
                    ""type"": ""Button"",
                    ""id"": ""d1bea059-e0b8-4468-9b3c-226093891932"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PickUpItem"",
                    ""type"": ""Button"",
                    ""id"": ""d38388bb-907d-4652-b232-ea1719906c6e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""df052f3f-ab29-4202-a032-b86fda06e077"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ac081e26-7a4a-4499-b39e-977541be61ac"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slot1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c449f25-4108-4356-9057-f13dfb12b1cb"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slot2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5197dfe2-4c20-4008-86ce-b9958707ba94"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slot3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""acd1bd20-d318-485f-b805-d703c6e6b8fc"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickUpItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6f89bdb-942c-423c-9242-f426df1c8846"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Items"",
            ""id"": ""5b256207-f509-40c9-8a6e-35242e2de8a3"",
            ""actions"": [
                {
                    ""name"": ""Usage"",
                    ""type"": ""Button"",
                    ""id"": ""061a4062-da9d-4f9d-9323-aceceacc91f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AlternativeUsage"",
                    ""type"": ""Button"",
                    ""id"": ""6458a41e-0f8b-4cf6-9c78-4b81b2da18b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cda4e057-1999-4dab-81c4-4edea1711f3b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Usage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce08f7f3-e924-41f9-83b1-3a8c714ae83e"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AlternativeUsage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Attack"",
            ""id"": ""40ddeaf3-4431-46ce-b6fb-5e59a21e7ccf"",
            ""actions"": [
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""1d1db5bb-22fc-4acb-bf8e-83f43b6fd6b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""77a19fb6-32e2-4622-8791-13759bea34df"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Interaction"",
            ""id"": ""7877693e-1b92-4bbd-855b-f15e1ed91b01"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""8ab9bf83-87d6-4860-8d4d-94bf586120a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c1358cec-4cf5-452b-8e2e-9a29b7bf6a20"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""37ec679a-202f-4d49-bcb5-22a22d4f10c4"",
            ""actions"": [
                {
                    ""name"": ""OpenTasksMenu"",
                    ""type"": ""Button"",
                    ""id"": ""0c3f0108-2aa5-40f4-8c79-270a8a475703"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9617d2dd-b7b7-414c-9c50-185c6641f02d"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenTasksMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e17b4b7-719a-4661-bc36-bfbfc90d23ba"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenTasksMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Vertical = m_Movement.FindAction("Vertical", throwIfNotFound: true);
        m_Movement_Horizontal = m_Movement.FindAction("Horizontal", throwIfNotFound: true);
        m_Movement_Run = m_Movement.FindAction("Run", throwIfNotFound: true);
        m_Movement_Crouch = m_Movement.FindAction("Crouch", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_X_axis = m_Camera.FindAction("X_axis", throwIfNotFound: true);
        m_Camera_Y_axis = m_Camera.FindAction("Y_axis", throwIfNotFound: true);
        // Hand
        m_Hand = asset.FindActionMap("Hand", throwIfNotFound: true);
        m_Hand_Slot1 = m_Hand.FindAction("Slot1", throwIfNotFound: true);
        m_Hand_Slot2 = m_Hand.FindAction("Slot2", throwIfNotFound: true);
        m_Hand_Slot3 = m_Hand.FindAction("Slot3", throwIfNotFound: true);
        m_Hand_PickUpItem = m_Hand.FindAction("PickUpItem", throwIfNotFound: true);
        m_Hand_Interact = m_Hand.FindAction("Interact", throwIfNotFound: true);
        // Items
        m_Items = asset.FindActionMap("Items", throwIfNotFound: true);
        m_Items_Usage = m_Items.FindAction("Usage", throwIfNotFound: true);
        m_Items_AlternativeUsage = m_Items.FindAction("AlternativeUsage", throwIfNotFound: true);
        // Attack
        m_Attack = asset.FindActionMap("Attack", throwIfNotFound: true);
        m_Attack_Attack = m_Attack.FindAction("Attack", throwIfNotFound: true);
        // Interaction
        m_Interaction = asset.FindActionMap("Interaction", throwIfNotFound: true);
        m_Interaction_Interact = m_Interaction.FindAction("Interact", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_OpenTasksMenu = m_UI.FindAction("OpenTasksMenu", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Vertical;
    private readonly InputAction m_Movement_Horizontal;
    private readonly InputAction m_Movement_Run;
    private readonly InputAction m_Movement_Crouch;
    public struct MovementActions
    {
        private @Controls m_Wrapper;
        public MovementActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Vertical => m_Wrapper.m_Movement_Vertical;
        public InputAction @Horizontal => m_Wrapper.m_Movement_Horizontal;
        public InputAction @Run => m_Wrapper.m_Movement_Run;
        public InputAction @Crouch => m_Wrapper.m_Movement_Crouch;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Vertical.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnVertical;
                @Horizontal.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontal;
                @Run.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnRun;
                @Crouch.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnCrouch;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_X_axis;
    private readonly InputAction m_Camera_Y_axis;
    public struct CameraActions
    {
        private @Controls m_Wrapper;
        public CameraActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @X_axis => m_Wrapper.m_Camera_X_axis;
        public InputAction @Y_axis => m_Wrapper.m_Camera_Y_axis;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @X_axis.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnX_axis;
                @X_axis.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnX_axis;
                @X_axis.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnX_axis;
                @Y_axis.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnY_axis;
                @Y_axis.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnY_axis;
                @Y_axis.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnY_axis;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @X_axis.started += instance.OnX_axis;
                @X_axis.performed += instance.OnX_axis;
                @X_axis.canceled += instance.OnX_axis;
                @Y_axis.started += instance.OnY_axis;
                @Y_axis.performed += instance.OnY_axis;
                @Y_axis.canceled += instance.OnY_axis;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);

    // Hand
    private readonly InputActionMap m_Hand;
    private IHandActions m_HandActionsCallbackInterface;
    private readonly InputAction m_Hand_Slot1;
    private readonly InputAction m_Hand_Slot2;
    private readonly InputAction m_Hand_Slot3;
    private readonly InputAction m_Hand_PickUpItem;
    private readonly InputAction m_Hand_Interact;
    public struct HandActions
    {
        private @Controls m_Wrapper;
        public HandActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Slot1 => m_Wrapper.m_Hand_Slot1;
        public InputAction @Slot2 => m_Wrapper.m_Hand_Slot2;
        public InputAction @Slot3 => m_Wrapper.m_Hand_Slot3;
        public InputAction @PickUpItem => m_Wrapper.m_Hand_PickUpItem;
        public InputAction @Interact => m_Wrapper.m_Hand_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Hand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HandActions set) { return set.Get(); }
        public void SetCallbacks(IHandActions instance)
        {
            if (m_Wrapper.m_HandActionsCallbackInterface != null)
            {
                @Slot1.started -= m_Wrapper.m_HandActionsCallbackInterface.OnSlot1;
                @Slot1.performed -= m_Wrapper.m_HandActionsCallbackInterface.OnSlot1;
                @Slot1.canceled -= m_Wrapper.m_HandActionsCallbackInterface.OnSlot1;
                @Slot2.started -= m_Wrapper.m_HandActionsCallbackInterface.OnSlot2;
                @Slot2.performed -= m_Wrapper.m_HandActionsCallbackInterface.OnSlot2;
                @Slot2.canceled -= m_Wrapper.m_HandActionsCallbackInterface.OnSlot2;
                @Slot3.started -= m_Wrapper.m_HandActionsCallbackInterface.OnSlot3;
                @Slot3.performed -= m_Wrapper.m_HandActionsCallbackInterface.OnSlot3;
                @Slot3.canceled -= m_Wrapper.m_HandActionsCallbackInterface.OnSlot3;
                @PickUpItem.started -= m_Wrapper.m_HandActionsCallbackInterface.OnPickUpItem;
                @PickUpItem.performed -= m_Wrapper.m_HandActionsCallbackInterface.OnPickUpItem;
                @PickUpItem.canceled -= m_Wrapper.m_HandActionsCallbackInterface.OnPickUpItem;
                @Interact.started -= m_Wrapper.m_HandActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_HandActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_HandActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_HandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Slot1.started += instance.OnSlot1;
                @Slot1.performed += instance.OnSlot1;
                @Slot1.canceled += instance.OnSlot1;
                @Slot2.started += instance.OnSlot2;
                @Slot2.performed += instance.OnSlot2;
                @Slot2.canceled += instance.OnSlot2;
                @Slot3.started += instance.OnSlot3;
                @Slot3.performed += instance.OnSlot3;
                @Slot3.canceled += instance.OnSlot3;
                @PickUpItem.started += instance.OnPickUpItem;
                @PickUpItem.performed += instance.OnPickUpItem;
                @PickUpItem.canceled += instance.OnPickUpItem;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public HandActions @Hand => new HandActions(this);

    // Items
    private readonly InputActionMap m_Items;
    private IItemsActions m_ItemsActionsCallbackInterface;
    private readonly InputAction m_Items_Usage;
    private readonly InputAction m_Items_AlternativeUsage;
    public struct ItemsActions
    {
        private @Controls m_Wrapper;
        public ItemsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Usage => m_Wrapper.m_Items_Usage;
        public InputAction @AlternativeUsage => m_Wrapper.m_Items_AlternativeUsage;
        public InputActionMap Get() { return m_Wrapper.m_Items; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ItemsActions set) { return set.Get(); }
        public void SetCallbacks(IItemsActions instance)
        {
            if (m_Wrapper.m_ItemsActionsCallbackInterface != null)
            {
                @Usage.started -= m_Wrapper.m_ItemsActionsCallbackInterface.OnUsage;
                @Usage.performed -= m_Wrapper.m_ItemsActionsCallbackInterface.OnUsage;
                @Usage.canceled -= m_Wrapper.m_ItemsActionsCallbackInterface.OnUsage;
                @AlternativeUsage.started -= m_Wrapper.m_ItemsActionsCallbackInterface.OnAlternativeUsage;
                @AlternativeUsage.performed -= m_Wrapper.m_ItemsActionsCallbackInterface.OnAlternativeUsage;
                @AlternativeUsage.canceled -= m_Wrapper.m_ItemsActionsCallbackInterface.OnAlternativeUsage;
            }
            m_Wrapper.m_ItemsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Usage.started += instance.OnUsage;
                @Usage.performed += instance.OnUsage;
                @Usage.canceled += instance.OnUsage;
                @AlternativeUsage.started += instance.OnAlternativeUsage;
                @AlternativeUsage.performed += instance.OnAlternativeUsage;
                @AlternativeUsage.canceled += instance.OnAlternativeUsage;
            }
        }
    }
    public ItemsActions @Items => new ItemsActions(this);

    // Attack
    private readonly InputActionMap m_Attack;
    private IAttackActions m_AttackActionsCallbackInterface;
    private readonly InputAction m_Attack_Attack;
    public struct AttackActions
    {
        private @Controls m_Wrapper;
        public AttackActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Attack => m_Wrapper.m_Attack_Attack;
        public InputActionMap Get() { return m_Wrapper.m_Attack; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AttackActions set) { return set.Get(); }
        public void SetCallbacks(IAttackActions instance)
        {
            if (m_Wrapper.m_AttackActionsCallbackInterface != null)
            {
                @Attack.started -= m_Wrapper.m_AttackActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_AttackActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_AttackActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_AttackActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public AttackActions @Attack => new AttackActions(this);

    // Interaction
    private readonly InputActionMap m_Interaction;
    private IInteractionActions m_InteractionActionsCallbackInterface;
    private readonly InputAction m_Interaction_Interact;
    public struct InteractionActions
    {
        private @Controls m_Wrapper;
        public InteractionActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Interaction_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Interaction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractionActions set) { return set.Get(); }
        public void SetCallbacks(IInteractionActions instance)
        {
            if (m_Wrapper.m_InteractionActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_InteractionActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_InteractionActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_InteractionActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_InteractionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public InteractionActions @Interaction => new InteractionActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_OpenTasksMenu;
    public struct UIActions
    {
        private @Controls m_Wrapper;
        public UIActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @OpenTasksMenu => m_Wrapper.m_UI_OpenTasksMenu;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @OpenTasksMenu.started -= m_Wrapper.m_UIActionsCallbackInterface.OnOpenTasksMenu;
                @OpenTasksMenu.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnOpenTasksMenu;
                @OpenTasksMenu.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnOpenTasksMenu;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @OpenTasksMenu.started += instance.OnOpenTasksMenu;
                @OpenTasksMenu.performed += instance.OnOpenTasksMenu;
                @OpenTasksMenu.canceled += instance.OnOpenTasksMenu;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IMovementActions
    {
        void OnVertical(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnX_axis(InputAction.CallbackContext context);
        void OnY_axis(InputAction.CallbackContext context);
    }
    public interface IHandActions
    {
        void OnSlot1(InputAction.CallbackContext context);
        void OnSlot2(InputAction.CallbackContext context);
        void OnSlot3(InputAction.CallbackContext context);
        void OnPickUpItem(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IItemsActions
    {
        void OnUsage(InputAction.CallbackContext context);
        void OnAlternativeUsage(InputAction.CallbackContext context);
    }
    public interface IAttackActions
    {
        void OnAttack(InputAction.CallbackContext context);
    }
    public interface IInteractionActions
    {
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnOpenTasksMenu(InputAction.CallbackContext context);
    }
}
