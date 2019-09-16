// GENERATED AUTOMATICALLY FROM 'Assets/InputFiles/Player1Controls.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class Player1Controls : IInputActionCollection
{
    private InputActionAsset asset;
    public Player1Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player1Controls"",
    ""maps"": [
        {
            ""name"": ""Movement1"",
            ""id"": ""01de2f23-6a47-46b8-831d-466fff58f14c"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""36ad5e5d-668a-4313-b0f1-c8bfe576e053"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""5f9027ba-21d0-42ef-94ff-8f4e28f4d94a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""dc07b2ef-92f7-4c3d-b50b-ccea283d5bbd"",
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
                    ""id"": ""ef8b419d-9d26-4974-889c-e8da399c974c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""59fb8802-ca72-44f2-9509-973376e40e76"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""eb3ee361-1eaa-4b28-95b6-1d9089344be5"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""36c0194b-2bcb-4769-937b-e0f6392547ca"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d8775214-d0dc-4e55-9f80-a7a2ffa6eba0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Movement2"",
            ""id"": ""79be72ef-16ea-421f-ae0f-9318ba4beb06"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""17ed22db-c455-438d-8893-ba02e0fb22ba"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8369eda9-88cf-4b8a-abc5-41cf27eabd5b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e76e3f49-2bb6-4c1e-8559-b9d4f0672b2d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb305e2f-7c2a-4b0f-afdb-2ee7cf982612"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Movement3"",
            ""id"": ""e06070a0-5dc3-4b92-aa19-c176890e6440"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""29b19357-665c-40d8-8ca7-d309c8ddb292"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""5228c84a-d5c7-48ed-a1c9-24a7b0105756"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""045f9780-cc60-4b5f-8866-a01420b628c5"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""1f949eae-2d90-4563-97f0-d604b7f274b4"",
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
                    ""id"": ""7a3f71fc-2834-447c-af8b-acf3ce1dabd9"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d05852ef-1cf3-4e20-a0c3-6a9d8260e281"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b3738035-e363-4cd9-a28c-aa82bb46dde3"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""283ca111-0c3f-42c8-ae3c-d30219a6bb4f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b2b15b79-275d-4bfb-aa93-5b01948330fd"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c886a053-3513-4202-ad0c-7f253dea4213"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Movement4"",
            ""id"": ""75128908-056c-4dcf-b1c3-9c50c20dbfdf"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""734c5fa6-ce0d-4390-b3f5-3aa7985efd0a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""74f94981-7fbb-40a8-81ed-23a7aa804976"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c5c03bc2-9574-4b12-9d6c-e738a5f707a9"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca4188b5-1574-4a5e-889c-c065972b9fd4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0fa1ace-0a3f-4ca8-a73a-05253f64f36c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c05d33cc-3367-493c-a85c-9ea9a079ad03"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e8a6553a-62a2-4fc9-9142-c266f7e2dfb0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5337200f-308d-4fab-90d4-5e83bb45a196"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ad6809cd-d804-4fd1-8762-6cdc2d5d5fbc"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1f16c76a-7823-4b2a-9941-44c4d867a9ff"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement1
        m_Movement1 = asset.GetActionMap("Movement1");
        m_Movement1_Movement = m_Movement1.GetAction("Movement");
        m_Movement1_Jump = m_Movement1.GetAction("Jump");
        // Movement2
        m_Movement2 = asset.GetActionMap("Movement2");
        m_Movement2_Movement = m_Movement2.GetAction("Movement");
        m_Movement2_Jump = m_Movement2.GetAction("Jump");
        // Movement3
        m_Movement3 = asset.GetActionMap("Movement3");
        m_Movement3_Movement = m_Movement3.GetAction("Movement");
        m_Movement3_Jump = m_Movement3.GetAction("Jump");
        // Movement4
        m_Movement4 = asset.GetActionMap("Movement4");
        m_Movement4_Movement = m_Movement4.GetAction("Movement");
        m_Movement4_Jump = m_Movement4.GetAction("Jump");
    }

    ~Player1Controls()
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

    // Movement1
    private readonly InputActionMap m_Movement1;
    private IMovement1Actions m_Movement1ActionsCallbackInterface;
    private readonly InputAction m_Movement1_Movement;
    private readonly InputAction m_Movement1_Jump;
    public struct Movement1Actions
    {
        private Player1Controls m_Wrapper;
        public Movement1Actions(Player1Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Movement1_Movement;
        public InputAction @Jump => m_Wrapper.m_Movement1_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Movement1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Movement1Actions set) { return set.Get(); }
        public void SetCallbacks(IMovement1Actions instance)
        {
            if (m_Wrapper.m_Movement1ActionsCallbackInterface != null)
            {
                Movement.started -= m_Wrapper.m_Movement1ActionsCallbackInterface.OnMovement;
                Movement.performed -= m_Wrapper.m_Movement1ActionsCallbackInterface.OnMovement;
                Movement.canceled -= m_Wrapper.m_Movement1ActionsCallbackInterface.OnMovement;
                Jump.started -= m_Wrapper.m_Movement1ActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_Movement1ActionsCallbackInterface.OnJump;
                Jump.canceled -= m_Wrapper.m_Movement1ActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_Movement1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                Movement.started += instance.OnMovement;
                Movement.performed += instance.OnMovement;
                Movement.canceled += instance.OnMovement;
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.canceled += instance.OnJump;
            }
        }
    }
    public Movement1Actions @Movement1 => new Movement1Actions(this);

    // Movement2
    private readonly InputActionMap m_Movement2;
    private IMovement2Actions m_Movement2ActionsCallbackInterface;
    private readonly InputAction m_Movement2_Movement;
    private readonly InputAction m_Movement2_Jump;
    public struct Movement2Actions
    {
        private Player1Controls m_Wrapper;
        public Movement2Actions(Player1Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Movement2_Movement;
        public InputAction @Jump => m_Wrapper.m_Movement2_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Movement2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Movement2Actions set) { return set.Get(); }
        public void SetCallbacks(IMovement2Actions instance)
        {
            if (m_Wrapper.m_Movement2ActionsCallbackInterface != null)
            {
                Movement.started -= m_Wrapper.m_Movement2ActionsCallbackInterface.OnMovement;
                Movement.performed -= m_Wrapper.m_Movement2ActionsCallbackInterface.OnMovement;
                Movement.canceled -= m_Wrapper.m_Movement2ActionsCallbackInterface.OnMovement;
                Jump.started -= m_Wrapper.m_Movement2ActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_Movement2ActionsCallbackInterface.OnJump;
                Jump.canceled -= m_Wrapper.m_Movement2ActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_Movement2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                Movement.started += instance.OnMovement;
                Movement.performed += instance.OnMovement;
                Movement.canceled += instance.OnMovement;
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.canceled += instance.OnJump;
            }
        }
    }
    public Movement2Actions @Movement2 => new Movement2Actions(this);

    // Movement3
    private readonly InputActionMap m_Movement3;
    private IMovement3Actions m_Movement3ActionsCallbackInterface;
    private readonly InputAction m_Movement3_Movement;
    private readonly InputAction m_Movement3_Jump;
    public struct Movement3Actions
    {
        private Player1Controls m_Wrapper;
        public Movement3Actions(Player1Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Movement3_Movement;
        public InputAction @Jump => m_Wrapper.m_Movement3_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Movement3; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Movement3Actions set) { return set.Get(); }
        public void SetCallbacks(IMovement3Actions instance)
        {
            if (m_Wrapper.m_Movement3ActionsCallbackInterface != null)
            {
                Movement.started -= m_Wrapper.m_Movement3ActionsCallbackInterface.OnMovement;
                Movement.performed -= m_Wrapper.m_Movement3ActionsCallbackInterface.OnMovement;
                Movement.canceled -= m_Wrapper.m_Movement3ActionsCallbackInterface.OnMovement;
                Jump.started -= m_Wrapper.m_Movement3ActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_Movement3ActionsCallbackInterface.OnJump;
                Jump.canceled -= m_Wrapper.m_Movement3ActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_Movement3ActionsCallbackInterface = instance;
            if (instance != null)
            {
                Movement.started += instance.OnMovement;
                Movement.performed += instance.OnMovement;
                Movement.canceled += instance.OnMovement;
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.canceled += instance.OnJump;
            }
        }
    }
    public Movement3Actions @Movement3 => new Movement3Actions(this);

    // Movement4
    private readonly InputActionMap m_Movement4;
    private IMovement4Actions m_Movement4ActionsCallbackInterface;
    private readonly InputAction m_Movement4_Movement;
    private readonly InputAction m_Movement4_Jump;
    public struct Movement4Actions
    {
        private Player1Controls m_Wrapper;
        public Movement4Actions(Player1Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Movement4_Movement;
        public InputAction @Jump => m_Wrapper.m_Movement4_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Movement4; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Movement4Actions set) { return set.Get(); }
        public void SetCallbacks(IMovement4Actions instance)
        {
            if (m_Wrapper.m_Movement4ActionsCallbackInterface != null)
            {
                Movement.started -= m_Wrapper.m_Movement4ActionsCallbackInterface.OnMovement;
                Movement.performed -= m_Wrapper.m_Movement4ActionsCallbackInterface.OnMovement;
                Movement.canceled -= m_Wrapper.m_Movement4ActionsCallbackInterface.OnMovement;
                Jump.started -= m_Wrapper.m_Movement4ActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_Movement4ActionsCallbackInterface.OnJump;
                Jump.canceled -= m_Wrapper.m_Movement4ActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_Movement4ActionsCallbackInterface = instance;
            if (instance != null)
            {
                Movement.started += instance.OnMovement;
                Movement.performed += instance.OnMovement;
                Movement.canceled += instance.OnMovement;
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.canceled += instance.OnJump;
            }
        }
    }
    public Movement4Actions @Movement4 => new Movement4Actions(this);
    public interface IMovement1Actions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IMovement2Actions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IMovement3Actions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IMovement4Actions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
