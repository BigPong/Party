// GENERATED AUTOMATICALLY FROM 'Assets/BigPong/Input/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""fe2a82f3-bbc0-4015-9bb3-2d6173c284e6"",
            ""actions"": [
                {
                    ""name"": ""MoveY"",
                    ""type"": ""Value"",
                    ""id"": ""44fee397-7a1c-4880-830d-178d9dcccb85"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveX"",
                    ""type"": ""Value"",
                    ""id"": ""9346b9d6-47e2-4e25-863d-3277194022b3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""9f135245-1434-49d6-8130-6db1f22c10c6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Pick"",
                    ""type"": ""Button"",
                    ""id"": ""c39d4c13-e5e3-4a49-97e1-c8410d7b262f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Release"",
                    ""type"": ""Button"",
                    ""id"": ""dec73cab-0f4a-466c-976a-1743f5822c84"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Throw"",
                    ""type"": ""Button"",
                    ""id"": ""1883b29a-41db-47e9-b042-19d5c64a2e52"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Test"",
                    ""type"": ""Button"",
                    ""id"": ""6f7c1c1c-c7ce-4280-8252-829c4af75de5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""b26c138d-b7f2-4c75-8f81-05784d3351d6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pad_Up"",
                    ""type"": ""Button"",
                    ""id"": ""39b36c9d-b321-4af7-8418-fa1280169c31"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pad_Down"",
                    ""type"": ""Button"",
                    ""id"": ""2043ad6a-1557-462e-b38c-129ed837a476"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pad_Left"",
                    ""type"": ""Button"",
                    ""id"": ""a09874c5-db05-4d8d-b81d-0feaf234e8a3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pad_Right"",
                    ""type"": ""Button"",
                    ""id"": ""50b8513b-073a-4948-ab49-10260f965bb8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""2aff28bc-8073-4430-8c8d-2c000cb852d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f0a94306-55e2-46ca-82f9-0401830cccb8"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53d2acf4-87ff-4ce4-92d4-ab95bb1714fa"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5527283-c3ea-4787-8a9c-a29bf721a387"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Pick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ffda010-e541-422a-855f-74202a2f10f0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Test"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8da6f623-23a5-4747-a710-d55fad0a0f00"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7d9329b-3e86-49e8-a7d7-ec5212a1e2a7"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4c33382-9d8c-41d1-90f1-4cdf6da70a95"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0855eb4-93b7-4bf0-a185-a9ff3086a3d8"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6af673b6-d4ed-411e-aa6b-c1bb31e223a3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Pad_Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""261dbfb2-1a7e-47bc-b233-2f95fc2852bf"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Pad_Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d55746f-f075-4527-a5b1-f903950ef32b"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Pad_Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7bdc31c6-8d45-47bc-ba8d-1e4cd9ae8124"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Pad_Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84a104bd-e96a-4018-bd34-8cb5ba8f2b10"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Pad_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46218998-2b86-42b4-90cd-b9138d5efdfa"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Pad_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""909c8135-cd40-47e4-9599-c78893e98bb9"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Pad_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27e305b6-46ef-4f47-bc72-095ff9a85821"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Pad_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5d6776f-c5ea-48ff-950c-6143c6cc6ac9"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""6fa339b3-4165-45d8-88cb-60071cd3b805"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2828fb0a-8940-495d-b81f-3f611ab43e4d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""371b2695-3903-48a4-8704-0b03b2c1727e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""042244bf-bba6-46ea-afb6-8ab2d220f035"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""3587d28a-4ac7-4990-a6a1-2c7d3858449f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e093195d-8f9b-4166-86e3-e79824986b96"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7f7d91a4-6cfa-4b69-b0ac-82675b796a2c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""195ebf66-6ff2-48ce-b49e-277dac2d5620"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b73ff779-7182-43b2-b1ae-b2ad439da9a5"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0430dfe7-9e14-4107-8ac9-ff6003e0b4b7"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Pick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ee38905-2861-4d4e-814b-7aa61216b1ed"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c96ebbdd-dc31-49c9-90d8-74e6b1ecf67e"",
                    ""path"": ""<Keyboard>/i"",
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
            ""name"": ""Creating(UI)"",
            ""id"": ""ecf6ec54-7fb1-45f9-af05-bc72897bbdc0"",
            ""actions"": [
                {
                    ""name"": ""UI_Right"",
                    ""type"": ""Button"",
                    ""id"": ""c12a4987-87ca-46d1-9397-f8c4e05e12ab"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Yes"",
                    ""type"": ""Button"",
                    ""id"": ""bfa2ec0e-45b3-42e3-91ad-91da130adba5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""df1e007f-d5bb-4427-b1bb-ba0131a69f31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UI_Left"",
                    ""type"": ""Button"",
                    ""id"": ""b8b88bc6-b5c4-41d4-aa61-9c0a6327702a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UI_Down"",
                    ""type"": ""Button"",
                    ""id"": ""e79d5edd-8950-4d70-9213-6e53e8af0d9f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UI_Up"",
                    ""type"": ""Button"",
                    ""id"": ""72517f52-7fe6-4b74-8df2-bb61ede1d3c0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Enter"",
                    ""type"": ""Button"",
                    ""id"": ""f39f90b4-7c04-4234-91ed-24f170904b90"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UI_Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a53a3ae3-c369-4e15-853f-e68f8b05b381"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RXAxis"",
                    ""type"": ""Value"",
                    ""id"": ""51d134a7-2b87-40b5-8907-7fa15e4b30ef"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RYAxis"",
                    ""type"": ""Value"",
                    ""id"": ""3ec8e582-189e-4e7f-a506-4cdb7d7e25cf"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a3b3f4ce-db93-4b5c-b33f-53c9e224d5ec"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""UI_Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""653c35c9-9fcd-4b39-860e-9e8d4ae617ab"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""UI_Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97ddd36e-9673-4781-9a6c-900f093e6c12"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""UI_Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28880be0-c56f-42f5-b044-95f05e50d971"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""UI_Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d72e6c7c-5ddc-4657-8d81-42f9d58d05be"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""UI_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33e7d9db-336c-4adc-a4e3-84623fe5225b"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""UI_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9110b639-68d0-41d9-9d6d-2b3a7f139568"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""UI_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18adfc2d-c141-4367-baf0-2e621368f7e4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""UI_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d7993d0-d2d1-41f2-bbfb-9d48cb203f85"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Yes"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53da02c7-a3aa-4fb0-a35c-04049fd6fc9f"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Yes"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b34893e9-a669-4abc-9ed6-1c4fea341a78"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60045b1c-4931-4891-9d06-e94b2dbd7c4f"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""keyboard"",
                    ""id"": ""334365ca-8137-4889-8c96-06ae8ec7da7b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UI_Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bae90811-b337-45d7-8afa-04da5327a230"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UI_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""54eb7eae-d444-4f09-be50-6fba24297408"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UI_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""abb1c99f-e435-4754-bc1e-75fed800b6e0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UI_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a638f8be-2d03-4158-b76a-0b9defa8620e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UI_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""96259b68-a89f-4711-8098-68ed89ae3731"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RXAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb4cb06b-1d41-4efd-96dc-49874dd76794"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RYAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4915d91f-fc6a-4d10-aaad-f2363826adeb"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""None"",
            ""id"": ""251e0ea4-829a-43a4-a46c-d73c342fee46"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""7d3cc1b8-9adb-49d2-8c54-96387a4c8a1c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eb89ff65-a446-4251-88de-d9b19d8a0272"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
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
        },
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_MoveY = m_GamePlay.FindAction("MoveY", throwIfNotFound: true);
        m_GamePlay_MoveX = m_GamePlay.FindAction("MoveX", throwIfNotFound: true);
        m_GamePlay_Shoot = m_GamePlay.FindAction("Shoot", throwIfNotFound: true);
        m_GamePlay_Pick = m_GamePlay.FindAction("Pick", throwIfNotFound: true);
        m_GamePlay_Release = m_GamePlay.FindAction("Release", throwIfNotFound: true);
        m_GamePlay_Throw = m_GamePlay.FindAction("Throw", throwIfNotFound: true);
        m_GamePlay_Test = m_GamePlay.FindAction("Test", throwIfNotFound: true);
        m_GamePlay_Pause = m_GamePlay.FindAction("Pause", throwIfNotFound: true);
        m_GamePlay_Pad_Up = m_GamePlay.FindAction("Pad_Up", throwIfNotFound: true);
        m_GamePlay_Pad_Down = m_GamePlay.FindAction("Pad_Down", throwIfNotFound: true);
        m_GamePlay_Pad_Left = m_GamePlay.FindAction("Pad_Left", throwIfNotFound: true);
        m_GamePlay_Pad_Right = m_GamePlay.FindAction("Pad_Right", throwIfNotFound: true);
        m_GamePlay_Interact = m_GamePlay.FindAction("Interact", throwIfNotFound: true);
        // Creating(UI)
        m_CreatingUI = asset.FindActionMap("Creating(UI)", throwIfNotFound: true);
        m_CreatingUI_UI_Right = m_CreatingUI.FindAction("UI_Right", throwIfNotFound: true);
        m_CreatingUI_Yes = m_CreatingUI.FindAction("Yes", throwIfNotFound: true);
        m_CreatingUI_Cancel = m_CreatingUI.FindAction("Cancel", throwIfNotFound: true);
        m_CreatingUI_UI_Left = m_CreatingUI.FindAction("UI_Left", throwIfNotFound: true);
        m_CreatingUI_UI_Down = m_CreatingUI.FindAction("UI_Down", throwIfNotFound: true);
        m_CreatingUI_UI_Up = m_CreatingUI.FindAction("UI_Up", throwIfNotFound: true);
        m_CreatingUI_Enter = m_CreatingUI.FindAction("Enter", throwIfNotFound: true);
        m_CreatingUI_UI_Move = m_CreatingUI.FindAction("UI_Move", throwIfNotFound: true);
        m_CreatingUI_RXAxis = m_CreatingUI.FindAction("RXAxis", throwIfNotFound: true);
        m_CreatingUI_RYAxis = m_CreatingUI.FindAction("RYAxis", throwIfNotFound: true);
        // None
        m_None = asset.FindActionMap("None", throwIfNotFound: true);
        m_None_Newaction = m_None.FindAction("New action", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_MoveY;
    private readonly InputAction m_GamePlay_MoveX;
    private readonly InputAction m_GamePlay_Shoot;
    private readonly InputAction m_GamePlay_Pick;
    private readonly InputAction m_GamePlay_Release;
    private readonly InputAction m_GamePlay_Throw;
    private readonly InputAction m_GamePlay_Test;
    private readonly InputAction m_GamePlay_Pause;
    private readonly InputAction m_GamePlay_Pad_Up;
    private readonly InputAction m_GamePlay_Pad_Down;
    private readonly InputAction m_GamePlay_Pad_Left;
    private readonly InputAction m_GamePlay_Pad_Right;
    private readonly InputAction m_GamePlay_Interact;
    public struct GamePlayActions
    {
        private @PlayerControls m_Wrapper;
        public GamePlayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveY => m_Wrapper.m_GamePlay_MoveY;
        public InputAction @MoveX => m_Wrapper.m_GamePlay_MoveX;
        public InputAction @Shoot => m_Wrapper.m_GamePlay_Shoot;
        public InputAction @Pick => m_Wrapper.m_GamePlay_Pick;
        public InputAction @Release => m_Wrapper.m_GamePlay_Release;
        public InputAction @Throw => m_Wrapper.m_GamePlay_Throw;
        public InputAction @Test => m_Wrapper.m_GamePlay_Test;
        public InputAction @Pause => m_Wrapper.m_GamePlay_Pause;
        public InputAction @Pad_Up => m_Wrapper.m_GamePlay_Pad_Up;
        public InputAction @Pad_Down => m_Wrapper.m_GamePlay_Pad_Down;
        public InputAction @Pad_Left => m_Wrapper.m_GamePlay_Pad_Left;
        public InputAction @Pad_Right => m_Wrapper.m_GamePlay_Pad_Right;
        public InputAction @Interact => m_Wrapper.m_GamePlay_Interact;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @MoveY.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMoveY;
                @MoveY.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMoveY;
                @MoveY.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMoveY;
                @MoveX.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMoveX;
                @MoveX.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMoveX;
                @MoveX.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMoveX;
                @Shoot.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnShoot;
                @Pick.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPick;
                @Pick.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPick;
                @Pick.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPick;
                @Release.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRelease;
                @Release.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRelease;
                @Release.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRelease;
                @Throw.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnThrow;
                @Throw.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnThrow;
                @Throw.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnThrow;
                @Test.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTest;
                @Test.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTest;
                @Test.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTest;
                @Pause.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPause;
                @Pad_Up.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPad_Up;
                @Pad_Up.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPad_Up;
                @Pad_Up.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPad_Up;
                @Pad_Down.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPad_Down;
                @Pad_Down.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPad_Down;
                @Pad_Down.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPad_Down;
                @Pad_Left.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPad_Left;
                @Pad_Left.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPad_Left;
                @Pad_Left.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPad_Left;
                @Pad_Right.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPad_Right;
                @Pad_Right.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPad_Right;
                @Pad_Right.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPad_Right;
                @Interact.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveY.started += instance.OnMoveY;
                @MoveY.performed += instance.OnMoveY;
                @MoveY.canceled += instance.OnMoveY;
                @MoveX.started += instance.OnMoveX;
                @MoveX.performed += instance.OnMoveX;
                @MoveX.canceled += instance.OnMoveX;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Pick.started += instance.OnPick;
                @Pick.performed += instance.OnPick;
                @Pick.canceled += instance.OnPick;
                @Release.started += instance.OnRelease;
                @Release.performed += instance.OnRelease;
                @Release.canceled += instance.OnRelease;
                @Throw.started += instance.OnThrow;
                @Throw.performed += instance.OnThrow;
                @Throw.canceled += instance.OnThrow;
                @Test.started += instance.OnTest;
                @Test.performed += instance.OnTest;
                @Test.canceled += instance.OnTest;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Pad_Up.started += instance.OnPad_Up;
                @Pad_Up.performed += instance.OnPad_Up;
                @Pad_Up.canceled += instance.OnPad_Up;
                @Pad_Down.started += instance.OnPad_Down;
                @Pad_Down.performed += instance.OnPad_Down;
                @Pad_Down.canceled += instance.OnPad_Down;
                @Pad_Left.started += instance.OnPad_Left;
                @Pad_Left.performed += instance.OnPad_Left;
                @Pad_Left.canceled += instance.OnPad_Left;
                @Pad_Right.started += instance.OnPad_Right;
                @Pad_Right.performed += instance.OnPad_Right;
                @Pad_Right.canceled += instance.OnPad_Right;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);

    // Creating(UI)
    private readonly InputActionMap m_CreatingUI;
    private ICreatingUIActions m_CreatingUIActionsCallbackInterface;
    private readonly InputAction m_CreatingUI_UI_Right;
    private readonly InputAction m_CreatingUI_Yes;
    private readonly InputAction m_CreatingUI_Cancel;
    private readonly InputAction m_CreatingUI_UI_Left;
    private readonly InputAction m_CreatingUI_UI_Down;
    private readonly InputAction m_CreatingUI_UI_Up;
    private readonly InputAction m_CreatingUI_Enter;
    private readonly InputAction m_CreatingUI_UI_Move;
    private readonly InputAction m_CreatingUI_RXAxis;
    private readonly InputAction m_CreatingUI_RYAxis;
    public struct CreatingUIActions
    {
        private @PlayerControls m_Wrapper;
        public CreatingUIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @UI_Right => m_Wrapper.m_CreatingUI_UI_Right;
        public InputAction @Yes => m_Wrapper.m_CreatingUI_Yes;
        public InputAction @Cancel => m_Wrapper.m_CreatingUI_Cancel;
        public InputAction @UI_Left => m_Wrapper.m_CreatingUI_UI_Left;
        public InputAction @UI_Down => m_Wrapper.m_CreatingUI_UI_Down;
        public InputAction @UI_Up => m_Wrapper.m_CreatingUI_UI_Up;
        public InputAction @Enter => m_Wrapper.m_CreatingUI_Enter;
        public InputAction @UI_Move => m_Wrapper.m_CreatingUI_UI_Move;
        public InputAction @RXAxis => m_Wrapper.m_CreatingUI_RXAxis;
        public InputAction @RYAxis => m_Wrapper.m_CreatingUI_RYAxis;
        public InputActionMap Get() { return m_Wrapper.m_CreatingUI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CreatingUIActions set) { return set.Get(); }
        public void SetCallbacks(ICreatingUIActions instance)
        {
            if (m_Wrapper.m_CreatingUIActionsCallbackInterface != null)
            {
                @UI_Right.started -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnUI_Right;
                @UI_Right.performed -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnUI_Right;
                @UI_Right.canceled -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnUI_Right;
                @Yes.started -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnYes;
                @Yes.performed -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnYes;
                @Yes.canceled -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnYes;
                @Cancel.started -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnCancel;
                @UI_Left.started -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnUI_Left;
                @UI_Left.performed -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnUI_Left;
                @UI_Left.canceled -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnUI_Left;
                @UI_Down.started -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnUI_Down;
                @UI_Down.performed -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnUI_Down;
                @UI_Down.canceled -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnUI_Down;
                @UI_Up.started -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnUI_Up;
                @UI_Up.performed -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnUI_Up;
                @UI_Up.canceled -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnUI_Up;
                @Enter.started -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnEnter;
                @Enter.performed -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnEnter;
                @Enter.canceled -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnEnter;
                @UI_Move.started -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnUI_Move;
                @UI_Move.performed -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnUI_Move;
                @UI_Move.canceled -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnUI_Move;
                @RXAxis.started -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnRXAxis;
                @RXAxis.performed -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnRXAxis;
                @RXAxis.canceled -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnRXAxis;
                @RYAxis.started -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnRYAxis;
                @RYAxis.performed -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnRYAxis;
                @RYAxis.canceled -= m_Wrapper.m_CreatingUIActionsCallbackInterface.OnRYAxis;
            }
            m_Wrapper.m_CreatingUIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @UI_Right.started += instance.OnUI_Right;
                @UI_Right.performed += instance.OnUI_Right;
                @UI_Right.canceled += instance.OnUI_Right;
                @Yes.started += instance.OnYes;
                @Yes.performed += instance.OnYes;
                @Yes.canceled += instance.OnYes;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @UI_Left.started += instance.OnUI_Left;
                @UI_Left.performed += instance.OnUI_Left;
                @UI_Left.canceled += instance.OnUI_Left;
                @UI_Down.started += instance.OnUI_Down;
                @UI_Down.performed += instance.OnUI_Down;
                @UI_Down.canceled += instance.OnUI_Down;
                @UI_Up.started += instance.OnUI_Up;
                @UI_Up.performed += instance.OnUI_Up;
                @UI_Up.canceled += instance.OnUI_Up;
                @Enter.started += instance.OnEnter;
                @Enter.performed += instance.OnEnter;
                @Enter.canceled += instance.OnEnter;
                @UI_Move.started += instance.OnUI_Move;
                @UI_Move.performed += instance.OnUI_Move;
                @UI_Move.canceled += instance.OnUI_Move;
                @RXAxis.started += instance.OnRXAxis;
                @RXAxis.performed += instance.OnRXAxis;
                @RXAxis.canceled += instance.OnRXAxis;
                @RYAxis.started += instance.OnRYAxis;
                @RYAxis.performed += instance.OnRYAxis;
                @RYAxis.canceled += instance.OnRYAxis;
            }
        }
    }
    public CreatingUIActions @CreatingUI => new CreatingUIActions(this);

    // None
    private readonly InputActionMap m_None;
    private INoneActions m_NoneActionsCallbackInterface;
    private readonly InputAction m_None_Newaction;
    public struct NoneActions
    {
        private @PlayerControls m_Wrapper;
        public NoneActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_None_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_None; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NoneActions set) { return set.Get(); }
        public void SetCallbacks(INoneActions instance)
        {
            if (m_Wrapper.m_NoneActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_NoneActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_NoneActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_NoneActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_NoneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public NoneActions @None => new NoneActions(this);
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IGamePlayActions
    {
        void OnMoveY(InputAction.CallbackContext context);
        void OnMoveX(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnPick(InputAction.CallbackContext context);
        void OnRelease(InputAction.CallbackContext context);
        void OnThrow(InputAction.CallbackContext context);
        void OnTest(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnPad_Up(InputAction.CallbackContext context);
        void OnPad_Down(InputAction.CallbackContext context);
        void OnPad_Left(InputAction.CallbackContext context);
        void OnPad_Right(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface ICreatingUIActions
    {
        void OnUI_Right(InputAction.CallbackContext context);
        void OnYes(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnUI_Left(InputAction.CallbackContext context);
        void OnUI_Down(InputAction.CallbackContext context);
        void OnUI_Up(InputAction.CallbackContext context);
        void OnEnter(InputAction.CallbackContext context);
        void OnUI_Move(InputAction.CallbackContext context);
        void OnRXAxis(InputAction.CallbackContext context);
        void OnRYAxis(InputAction.CallbackContext context);
    }
    public interface INoneActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
