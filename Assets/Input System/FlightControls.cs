// GENERATED AUTOMATICALLY FROM 'Assets/Input System/FlightControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @FlightControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @FlightControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FlightControls"",
    ""maps"": [
        {
            ""name"": ""Flight"",
            ""id"": ""ee025930-7233-4a8d-a326-aef7c3920695"",
            ""actions"": [
                {
                    ""name"": ""Throttle"",
                    ""type"": ""Value"",
                    ""id"": ""b2003d48-a426-47dd-ba92-01d50b1cf270"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pitch"",
                    ""type"": ""Value"",
                    ""id"": ""964a04c3-0fc8-451a-9ebb-8ab7c19e97fa"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Yaw"",
                    ""type"": ""Value"",
                    ""id"": ""f15eefa2-c06a-448e-9cd1-cb740244d9d9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Value"",
                    ""id"": ""6968528b-b2ce-4659-b401-c28de26ea2f9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""e03bbde2-3a40-4746-a5dd-1ff35056df00"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""gamepad triggers"",
                    ""id"": ""54dbfb82-bbeb-44c4-a3a2-612706c2483b"",
                    ""path"": ""1DAxis(whichSideWins=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""53945336-7df9-4f83-bb9e-5b07d069ffe9"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""608a714f-7752-464c-bc41-4c72c14aaff9"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""keyboard up/down"",
                    ""id"": ""d58e5d15-3dbe-4b80-9858-38771e01aaab"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""11468a60-4923-405b-b81f-3b720ff66564"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2825784f-30bc-4221-8ed6-a2bafecec23d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""keyboard w/s"",
                    ""id"": ""4a46f657-2344-4dde-b2fd-e522fe189bfa"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""fb726257-9a02-40c4-8b74-d2c53e1c7bdf"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""695111c2-2e07-4529-93ef-b0cbdaab01cf"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""gamepad left joystick"",
                    ""id"": ""b751a337-b326-41be-8b15-d77bfae74655"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1d7d9446-718a-42f3-96c1-efd7ba1df058"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ff4088e7-349c-46dc-91f0-d6b9cc8bd7da"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""keyboard left/right"",
                    ""id"": ""5b531c65-8382-44a9-9e98-855bc7d98342"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""dd39c62d-f8ab-4649-9ccd-f413072b9f65"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3505c1c1-2f1b-4d4d-abf4-d2aa5d6aa5ef"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""gamepad right joystick"",
                    ""id"": ""3ade7609-56c7-46bf-80cc-37953a5fc5ac"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ee5c671a-3d85-425c-854a-2c4f75229ac6"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""49668511-305d-4e55-9623-fc7dd4716de5"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""keyboard a/d"",
                    ""id"": ""a2083674-0521-4184-8b8f-0929e37718ad"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e11e88a8-8e04-4bb8-85e4-7b4daee57800"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""20085ad2-bbfa-4dac-8904-b3db9731a8ea"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""gamepad left joystick"",
                    ""id"": ""dd47ea8b-44d9-40a9-925a-e3c346290b07"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3d9bb518-91b5-4a3a-bc75-b3108d6aaace"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""103dee51-1763-484a-9fbc-e63551cda826"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7aee8b7e-e9ba-4818-938a-b62ad33dda0b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45a1048c-82be-4233-9b00-e8530c314730"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""75d34e2e-417e-4a17-8e43-c7ca34bbe40d"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""1527c7a9-94e4-46a7-8dff-51ca587408b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""75a1d113-65f9-4fae-aff3-5b9229ec5acd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""a3a86c08-c721-4d46-965a-21d34bb4bc7f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""80415bce-866e-47aa-92e6-7cea95a5a63d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""59001c31-aca2-4a04-85a2-2423a839a20e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""3a801e81-514f-4785-b4a7-538187610277"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""84d5246a-652d-40c6-b14b-2f2b0223aa83"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a1a6f68-f2c9-41ed-b861-f89c7bb9ad5d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc59abdc-9658-4b0b-9ef2-f862a4c54efe"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f6bac8e-73bc-461e-8b83-4cf9bb17a32e"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""667044b8-91bb-4a27-b3b4-b696c26074f9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5626eb2b-0235-4674-8e85-b94d9c609fcb"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6fb6f45-8232-4f2d-bcc0-b43b7bea2f9d"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""deaa48db-0a6d-4250-ba7f-f68d9b21cfef"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0abccb6d-9907-4db1-a04d-c159acce4781"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13355763-fe17-4a33-8dcf-3eec301bb4f3"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88ff7dd6-f4d5-46e3-b9c1-e583d98f2d53"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c700ded-0032-4167-8bcb-51e0975d005d"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7fbf0e5-6554-47e6-a31a-062ad42966fe"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0a400e4-c61c-4078-9912-8d1e6fb2884a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0eccfac-1915-4f56-83f8-5394907b1a37"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9afe5b29-cbb9-443a-86d7-25a4e7d624fd"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc54272b-299b-4a14-b0c2-a36bb19bf69a"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c97fab77-db3f-4a31-b2ae-ba9456516a08"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d45a91d0-216a-491c-8c67-58b34210d9db"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6eceba21-810f-4cb7-9701-f6bb8422f474"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Phone Flight"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Phone Flight"",
            ""bindingGroup"": ""Phone Flight"",
            ""devices"": []
        }
    ]
}");
        // Flight
        m_Flight = asset.FindActionMap("Flight", throwIfNotFound: true);
        m_Flight_Throttle = m_Flight.FindAction("Throttle", throwIfNotFound: true);
        m_Flight_Pitch = m_Flight.FindAction("Pitch", throwIfNotFound: true);
        m_Flight_Yaw = m_Flight.FindAction("Yaw", throwIfNotFound: true);
        m_Flight_Roll = m_Flight.FindAction("Roll", throwIfNotFound: true);
        m_Flight_Pause = m_Flight.FindAction("Pause", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Up = m_Menu.FindAction("Up", throwIfNotFound: true);
        m_Menu_Down = m_Menu.FindAction("Down", throwIfNotFound: true);
        m_Menu_Left = m_Menu.FindAction("Left", throwIfNotFound: true);
        m_Menu_Right = m_Menu.FindAction("Right", throwIfNotFound: true);
        m_Menu_Select = m_Menu.FindAction("Select", throwIfNotFound: true);
        m_Menu_Back = m_Menu.FindAction("Back", throwIfNotFound: true);
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

    // Flight
    private readonly InputActionMap m_Flight;
    private IFlightActions m_FlightActionsCallbackInterface;
    private readonly InputAction m_Flight_Throttle;
    private readonly InputAction m_Flight_Pitch;
    private readonly InputAction m_Flight_Yaw;
    private readonly InputAction m_Flight_Roll;
    private readonly InputAction m_Flight_Pause;
    public struct FlightActions
    {
        private @FlightControls m_Wrapper;
        public FlightActions(@FlightControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Throttle => m_Wrapper.m_Flight_Throttle;
        public InputAction @Pitch => m_Wrapper.m_Flight_Pitch;
        public InputAction @Yaw => m_Wrapper.m_Flight_Yaw;
        public InputAction @Roll => m_Wrapper.m_Flight_Roll;
        public InputAction @Pause => m_Wrapper.m_Flight_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Flight; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FlightActions set) { return set.Get(); }
        public void SetCallbacks(IFlightActions instance)
        {
            if (m_Wrapper.m_FlightActionsCallbackInterface != null)
            {
                @Throttle.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnThrottle;
                @Throttle.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnThrottle;
                @Throttle.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnThrottle;
                @Pitch.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnPitch;
                @Pitch.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnPitch;
                @Pitch.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnPitch;
                @Yaw.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnYaw;
                @Yaw.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnYaw;
                @Yaw.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnYaw;
                @Roll.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnRoll;
                @Pause.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_FlightActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Throttle.started += instance.OnThrottle;
                @Throttle.performed += instance.OnThrottle;
                @Throttle.canceled += instance.OnThrottle;
                @Pitch.started += instance.OnPitch;
                @Pitch.performed += instance.OnPitch;
                @Pitch.canceled += instance.OnPitch;
                @Yaw.started += instance.OnYaw;
                @Yaw.performed += instance.OnYaw;
                @Yaw.canceled += instance.OnYaw;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public FlightActions @Flight => new FlightActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Up;
    private readonly InputAction m_Menu_Down;
    private readonly InputAction m_Menu_Left;
    private readonly InputAction m_Menu_Right;
    private readonly InputAction m_Menu_Select;
    private readonly InputAction m_Menu_Back;
    public struct MenuActions
    {
        private @FlightControls m_Wrapper;
        public MenuActions(@FlightControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_Menu_Up;
        public InputAction @Down => m_Wrapper.m_Menu_Down;
        public InputAction @Left => m_Wrapper.m_Menu_Left;
        public InputAction @Right => m_Wrapper.m_Menu_Right;
        public InputAction @Select => m_Wrapper.m_Menu_Select;
        public InputAction @Back => m_Wrapper.m_Menu_Back;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnRight;
                @Select.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @Back.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnBack;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int m_PhoneFlightSchemeIndex = -1;
    public InputControlScheme PhoneFlightScheme
    {
        get
        {
            if (m_PhoneFlightSchemeIndex == -1) m_PhoneFlightSchemeIndex = asset.FindControlSchemeIndex("Phone Flight");
            return asset.controlSchemes[m_PhoneFlightSchemeIndex];
        }
    }
    public interface IFlightActions
    {
        void OnThrottle(InputAction.CallbackContext context);
        void OnPitch(InputAction.CallbackContext context);
        void OnYaw(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
    }
}
