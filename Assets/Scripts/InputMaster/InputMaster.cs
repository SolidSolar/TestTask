// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputMaster/InputMaster.inputactions'

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
            ""name"": ""Tank"",
            ""id"": ""d51d6143-8ac0-47d7-8a17-a45ac2ed0370"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Value"",
                    ""id"": ""6c4e71a0-42af-4a85-bc35-cbafcdfc68a7"",
                    ""expectedControlType"": ""Key"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""453b205f-3ab3-421a-a319-68ae58d56be5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ecc11bf9-8c24-45af-846b-b815e0937c94"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Button"",
                    ""id"": ""efdc1d32-07c6-43c0-a22c-e0706a27d544"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""4fed3778-fef9-46ee-b948-c79c64997887"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e1b59986-0a72-408e-a342-1cddb0792e08"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d6ecc27-d055-4a75-93e0-1b716d6d195f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""bd165165-e38a-46a8-99ff-dd6b008d9208"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""9d519320-978e-4422-95a8-06e5c4fddd8a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""8d38d72c-8583-4226-8742-63c1c4ac6921"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""4edd518e-0474-4d0a-a798-40a6fce390ac"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""46f29cfa-1caf-45bf-ac19-72c2404e2ef8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a5fa291e-fa9c-495b-9ac2-378fda8476e7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""eb3ad069-5a4f-4495-9413-04ac8364f3a2"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=0)"",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac55a9f5-57a9-433e-b632-bec6c95fa839"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": ""Scale"",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d96e549e-9aba-4050-9261-2ea3fcd0750b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=2)"",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GameManager"",
            ""id"": ""d038ad8f-8ec6-4a82-aa6f-3aad598024c6"",
            ""actions"": [
                {
                    ""name"": ""ReloadScene"",
                    ""type"": ""Button"",
                    ""id"": ""2f3868b1-cab1-4d5a-9689-c2630a2f19f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0ccc2440-d8f1-45f1-9d85-8d31f3cb8b63"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReloadScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""keyboard and mouse"",
            ""bindingGroup"": ""keyboard and mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Tank
        m_Tank = asset.FindActionMap("Tank", throwIfNotFound: true);
        m_Tank_Fire = m_Tank.FindAction("Fire", throwIfNotFound: true);
        m_Tank_Aim = m_Tank.FindAction("Aim", throwIfNotFound: true);
        m_Tank_Movement = m_Tank.FindAction("Movement", throwIfNotFound: true);
        m_Tank_Rotation = m_Tank.FindAction("Rotation", throwIfNotFound: true);
        m_Tank_ChangeWeapon = m_Tank.FindAction("ChangeWeapon", throwIfNotFound: true);
        // GameManager
        m_GameManager = asset.FindActionMap("GameManager", throwIfNotFound: true);
        m_GameManager_ReloadScene = m_GameManager.FindAction("ReloadScene", throwIfNotFound: true);
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

    // Tank
    private readonly InputActionMap m_Tank;
    private ITankActions m_TankActionsCallbackInterface;
    private readonly InputAction m_Tank_Fire;
    private readonly InputAction m_Tank_Aim;
    private readonly InputAction m_Tank_Movement;
    private readonly InputAction m_Tank_Rotation;
    private readonly InputAction m_Tank_ChangeWeapon;
    public struct TankActions
    {
        private @InputMaster m_Wrapper;
        public TankActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire => m_Wrapper.m_Tank_Fire;
        public InputAction @Aim => m_Wrapper.m_Tank_Aim;
        public InputAction @Movement => m_Wrapper.m_Tank_Movement;
        public InputAction @Rotation => m_Wrapper.m_Tank_Rotation;
        public InputAction @ChangeWeapon => m_Wrapper.m_Tank_ChangeWeapon;
        public InputActionMap Get() { return m_Wrapper.m_Tank; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TankActions set) { return set.Get(); }
        public void SetCallbacks(ITankActions instance)
        {
            if (m_Wrapper.m_TankActionsCallbackInterface != null)
            {
                @Fire.started -= m_Wrapper.m_TankActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_TankActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_TankActionsCallbackInterface.OnFire;
                @Aim.started -= m_Wrapper.m_TankActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_TankActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_TankActionsCallbackInterface.OnAim;
                @Movement.started -= m_Wrapper.m_TankActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_TankActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_TankActionsCallbackInterface.OnMovement;
                @Rotation.started -= m_Wrapper.m_TankActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_TankActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_TankActionsCallbackInterface.OnRotation;
                @ChangeWeapon.started -= m_Wrapper.m_TankActionsCallbackInterface.OnChangeWeapon;
                @ChangeWeapon.performed -= m_Wrapper.m_TankActionsCallbackInterface.OnChangeWeapon;
                @ChangeWeapon.canceled -= m_Wrapper.m_TankActionsCallbackInterface.OnChangeWeapon;
            }
            m_Wrapper.m_TankActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @ChangeWeapon.started += instance.OnChangeWeapon;
                @ChangeWeapon.performed += instance.OnChangeWeapon;
                @ChangeWeapon.canceled += instance.OnChangeWeapon;
            }
        }
    }
    public TankActions @Tank => new TankActions(this);

    // GameManager
    private readonly InputActionMap m_GameManager;
    private IGameManagerActions m_GameManagerActionsCallbackInterface;
    private readonly InputAction m_GameManager_ReloadScene;
    public struct GameManagerActions
    {
        private @InputMaster m_Wrapper;
        public GameManagerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @ReloadScene => m_Wrapper.m_GameManager_ReloadScene;
        public InputActionMap Get() { return m_Wrapper.m_GameManager; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameManagerActions set) { return set.Get(); }
        public void SetCallbacks(IGameManagerActions instance)
        {
            if (m_Wrapper.m_GameManagerActionsCallbackInterface != null)
            {
                @ReloadScene.started -= m_Wrapper.m_GameManagerActionsCallbackInterface.OnReloadScene;
                @ReloadScene.performed -= m_Wrapper.m_GameManagerActionsCallbackInterface.OnReloadScene;
                @ReloadScene.canceled -= m_Wrapper.m_GameManagerActionsCallbackInterface.OnReloadScene;
            }
            m_Wrapper.m_GameManagerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ReloadScene.started += instance.OnReloadScene;
                @ReloadScene.performed += instance.OnReloadScene;
                @ReloadScene.canceled += instance.OnReloadScene;
            }
        }
    }
    public GameManagerActions @GameManager => new GameManagerActions(this);
    private int m_keyboardandmouseSchemeIndex = -1;
    public InputControlScheme keyboardandmouseScheme
    {
        get
        {
            if (m_keyboardandmouseSchemeIndex == -1) m_keyboardandmouseSchemeIndex = asset.FindControlSchemeIndex("keyboard and mouse");
            return asset.controlSchemes[m_keyboardandmouseSchemeIndex];
        }
    }
    public interface ITankActions
    {
        void OnFire(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnChangeWeapon(InputAction.CallbackContext context);
    }
    public interface IGameManagerActions
    {
        void OnReloadScene(InputAction.CallbackContext context);
    }
}
