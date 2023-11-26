using System;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

namespace UnityEngine
{
    public class Input
    {
        public static bool GetKeyUp(KeyCode key)
        {
            return GetKBKeyByKeyCode(key).wasReleasedThisFrame;
        }

        public static bool GetKeyDown(KeyCode key)
        {
            return GetKBKeyByKeyCode(key).wasPressedThisFrame;
        }

        public static bool GetKey(KeyCode key)
        {
            return GetKBKeyByKeyCode(key).isPressed;
        }

        public static bool GetMouseButtonUp(KeyCode button)
        {
            return GetMouseButtonByKeyCode(button).wasReleasedThisFrame;
        }

        public static bool GetMouseButtonDown(KeyCode button)
        {
            return GetMouseButtonByKeyCode(button).wasPressedThisFrame;
        }

        public static bool GetMouseButton(KeyCode button)
        {
            return GetMouseButtonByKeyCode(button).isPressed;
        }

        public static Vector2 mousePosition => new Vector2(InputSystem.GetDevice<Mouse>().position.x.ReadValue(), InputSystem.GetDevice<Mouse>().position.y.ReadValue());

        /// <summary>
        /// To Do: Joystick Support
        /// </summary>
        /// <param name="key">The Key To Get</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static KeyControl GetKBKeyByKeyCode(KeyCode key)
        {
            switch (key)
            {
                case KeyCode.Backspace:
                    return InputSystem.GetDevice<Keyboard>().backspaceKey;
                case KeyCode.Delete:
                    return InputSystem.GetDevice<Keyboard>().deleteKey;
                case KeyCode.Tab:
                    return InputSystem.GetDevice<Keyboard>().tabKey;
                case KeyCode.Return:
                    return InputSystem.GetDevice<Keyboard>().enterKey;
                case KeyCode.Pause:
                    return InputSystem.GetDevice<Keyboard>().pauseKey;
                case KeyCode.Escape:
                    return InputSystem.GetDevice<Keyboard>().escapeKey;
                case KeyCode.Space:
                    return InputSystem.GetDevice<Keyboard>().spaceKey;
                case KeyCode.Keypad0:
                    return InputSystem.GetDevice<Keyboard>().numpad0Key;
                case KeyCode.Keypad1:
                    return InputSystem.GetDevice<Keyboard>().numpad1Key;
                case KeyCode.Keypad2:
                    return InputSystem.GetDevice<Keyboard>().numpad2Key;
                case KeyCode.Keypad3:
                    return InputSystem.GetDevice<Keyboard>().numpad3Key;
                case KeyCode.Keypad4:
                    return InputSystem.GetDevice<Keyboard>().numpad4Key;
                case KeyCode.Keypad5:
                    return InputSystem.GetDevice<Keyboard>().numpad5Key;
                case KeyCode.Keypad6:
                    return InputSystem.GetDevice<Keyboard>().numpad6Key;
                case KeyCode.Keypad7:
                    return InputSystem.GetDevice<Keyboard>().numpad7Key;
                case KeyCode.Keypad8:
                    return InputSystem.GetDevice<Keyboard>().numpad8Key;
                case KeyCode.Keypad9:
                    return InputSystem.GetDevice<Keyboard>().numpad9Key;
                case KeyCode.KeypadPeriod:
                    return InputSystem.GetDevice<Keyboard>().numpadPeriodKey;
                case KeyCode.KeypadDivide:
                    return InputSystem.GetDevice<Keyboard>().numpadDivideKey;
                case KeyCode.KeypadMultiply:
                    return InputSystem.GetDevice<Keyboard>().numpadMultiplyKey;
                case KeyCode.KeypadMinus:
                    return InputSystem.GetDevice<Keyboard>().numpadMinusKey;
                case KeyCode.KeypadPlus:
                    return InputSystem.GetDevice<Keyboard>().numpadPlusKey;
                case KeyCode.KeypadEnter:
                    return InputSystem.GetDevice<Keyboard>().numpadEnterKey;
                case KeyCode.KeypadEquals:
                    return InputSystem.GetDevice<Keyboard>().numpadEqualsKey;
                case KeyCode.UpArrow:
                    return InputSystem.GetDevice<Keyboard>().upArrowKey;
                case KeyCode.DownArrow:
                    return InputSystem.GetDevice<Keyboard>().downArrowKey;
                case KeyCode.RightArrow:
                    return InputSystem.GetDevice<Keyboard>().rightArrowKey;
                case KeyCode.LeftArrow:
                    return InputSystem.GetDevice<Keyboard>().leftArrowKey;
                case KeyCode.Insert:
                    return InputSystem.GetDevice<Keyboard>().insertKey;
                case KeyCode.Home:
                    return InputSystem.GetDevice<Keyboard>().homeKey;
                case KeyCode.End:
                    return InputSystem.GetDevice<Keyboard>().endKey;
                case KeyCode.PageUp:
                    return InputSystem.GetDevice<Keyboard>().pageUpKey;
                case KeyCode.PageDown:
                    return InputSystem.GetDevice<Keyboard>().pageDownKey;
                case KeyCode.F1:
                    return InputSystem.GetDevice<Keyboard>().f1Key;
                case KeyCode.F2:
                    return InputSystem.GetDevice<Keyboard>().f2Key;
                case KeyCode.F3:
                    return InputSystem.GetDevice<Keyboard>().f3Key;
                case KeyCode.F4:
                    return InputSystem.GetDevice<Keyboard>().f4Key;
                case KeyCode.F5:
                    return InputSystem.GetDevice<Keyboard>().f5Key;
                case KeyCode.F6:
                    return InputSystem.GetDevice<Keyboard>().f6Key;
                case KeyCode.F7:
                    return InputSystem.GetDevice<Keyboard>().f7Key;
                case KeyCode.F8:
                    return InputSystem.GetDevice<Keyboard>().f8Key;
                case KeyCode.F9:
                    return InputSystem.GetDevice<Keyboard>().f9Key;
                case KeyCode.F10:
                    return InputSystem.GetDevice<Keyboard>().f10Key;
                case KeyCode.F11:
                    return InputSystem.GetDevice<Keyboard>().f11Key;
                case KeyCode.F12:
                    return InputSystem.GetDevice<Keyboard>().f12Key;
                case KeyCode.Alpha0:
                    return InputSystem.GetDevice<Keyboard>().digit0Key;
                case KeyCode.Alpha1:
                    return InputSystem.GetDevice<Keyboard>().digit1Key;
                case KeyCode.Alpha2:
                    return InputSystem.GetDevice<Keyboard>().digit2Key;
                case KeyCode.Alpha3:
                    return InputSystem.GetDevice<Keyboard>().digit3Key;
                case KeyCode.Alpha4:
                    return InputSystem.GetDevice<Keyboard>().digit4Key;
                case KeyCode.Alpha5:
                    return InputSystem.GetDevice<Keyboard>().digit5Key;
                case KeyCode.Alpha6:
                    return InputSystem.GetDevice<Keyboard>().digit6Key;
                case KeyCode.Alpha7:
                    return InputSystem.GetDevice<Keyboard>().digit7Key;
                case KeyCode.Alpha8:
                    return InputSystem.GetDevice<Keyboard>().digit7Key;
                case KeyCode.Alpha9:
                    return InputSystem.GetDevice<Keyboard>().digit9Key;
                case KeyCode.Quote:
                    return InputSystem.GetDevice<Keyboard>().quoteKey;
                case KeyCode.Comma:
                    return InputSystem.GetDevice<Keyboard>().commaKey;
                case KeyCode.Minus:
                    return InputSystem.GetDevice<Keyboard>().minusKey;
                case KeyCode.Period:
                    return InputSystem.GetDevice<Keyboard>().periodKey;
                case KeyCode.Slash:
                    return InputSystem.GetDevice<Keyboard>().slashKey;
                case KeyCode.Semicolon:
                    return InputSystem.GetDevice<Keyboard>().semicolonKey;
                case KeyCode.Equals:
                    return InputSystem.GetDevice<Keyboard>().equalsKey;
                case KeyCode.LeftBracket:
                    return InputSystem.GetDevice<Keyboard>().leftBracketKey;
                case KeyCode.Backslash:
                    return InputSystem.GetDevice<Keyboard>().backslashKey;
                case KeyCode.RightBracket:
                    return InputSystem.GetDevice<Keyboard>().rightBracketKey;
                case KeyCode.BackQuote:
                    return InputSystem.GetDevice<Keyboard>().backquoteKey;
                case KeyCode.A:
                    return InputSystem.GetDevice<Keyboard>().aKey;
                case KeyCode.B:
                    return InputSystem.GetDevice<Keyboard>().bKey;
                case KeyCode.C:
                    return InputSystem.GetDevice<Keyboard>().cKey;
                case KeyCode.D:
                    return InputSystem.GetDevice<Keyboard>().dKey;
                case KeyCode.E:
                    return InputSystem.GetDevice<Keyboard>().eKey;
                case KeyCode.F:
                    return InputSystem.GetDevice<Keyboard>().fKey;
                case KeyCode.G:
                    return InputSystem.GetDevice<Keyboard>().gKey;
                case KeyCode.H:
                    return InputSystem.GetDevice<Keyboard>().hKey;
                case KeyCode.I:
                    return InputSystem.GetDevice<Keyboard>().iKey;
                case KeyCode.J:
                    return InputSystem.GetDevice<Keyboard>().jKey;
                case KeyCode.K:
                    return InputSystem.GetDevice<Keyboard>().kKey;
                case KeyCode.L:
                    return InputSystem.GetDevice<Keyboard>().lKey;
                case KeyCode.M:
                    return InputSystem.GetDevice<Keyboard>().mKey;
                case KeyCode.N:
                    return InputSystem.GetDevice<Keyboard>().nKey;
                case KeyCode.O:
                    return InputSystem.GetDevice<Keyboard>().oKey;
                case KeyCode.P:
                    return InputSystem.GetDevice<Keyboard>().pKey;
                case KeyCode.Q:
                    return InputSystem.GetDevice<Keyboard>().qKey;
                case KeyCode.R:
                    return InputSystem.GetDevice<Keyboard>().rKey;
                case KeyCode.S:
                    return InputSystem.GetDevice<Keyboard>().sKey;
                case KeyCode.T:
                    return InputSystem.GetDevice<Keyboard>().tKey;
                case KeyCode.U:
                    return InputSystem.GetDevice<Keyboard>().uKey;
                case KeyCode.V:
                    return InputSystem.GetDevice<Keyboard>().vKey;
                case KeyCode.W:
                    return InputSystem.GetDevice<Keyboard>().wKey;
                case KeyCode.X:
                    return InputSystem.GetDevice<Keyboard>().xKey;
                case KeyCode.Y:
                    return InputSystem.GetDevice<Keyboard>().yKey;
                case KeyCode.Z:
                    return InputSystem.GetDevice<Keyboard>().zKey;
                case KeyCode.Numlock:
                    return InputSystem.GetDevice<Keyboard>().numLockKey;
                case KeyCode.CapsLock:
                    return InputSystem.GetDevice<Keyboard>().capsLockKey;
                case KeyCode.ScrollLock:
                    return InputSystem.GetDevice<Keyboard>().semicolonKey;
                case KeyCode.RightShift:
                    return InputSystem.GetDevice<Keyboard>().rightShiftKey;
                case KeyCode.LeftShift:
                    return InputSystem.GetDevice<Keyboard>().leftShiftKey;
                case KeyCode.RightControl:
                    return InputSystem.GetDevice<Keyboard>().rightCtrlKey;
                case KeyCode.LeftControl:
                    return InputSystem.GetDevice<Keyboard>().leftCtrlKey;
                case KeyCode.RightAlt:
                    return InputSystem.GetDevice<Keyboard>().rightAltKey;
                case KeyCode.LeftAlt:
                    return InputSystem.GetDevice<Keyboard>().leftAltKey;
                case KeyCode.LeftMeta:
                    return InputSystem.GetDevice<Keyboard>().leftMetaKey;
                case KeyCode.LeftWindows:
                    return InputSystem.GetDevice<Keyboard>().leftWindowsKey;
                case KeyCode.RightMeta:
                    return InputSystem.GetDevice<Keyboard>().rightMetaKey;
                case KeyCode.RightWindows:
                    return InputSystem.GetDevice<Keyboard>().rightWindowsKey;
                case KeyCode.Print:
                    return InputSystem.GetDevice<Keyboard>().printScreenKey;
                case KeyCode.JoystickButton0:
                case KeyCode.JoystickButton1:
                case KeyCode.JoystickButton2:
                case KeyCode.JoystickButton3:
                case KeyCode.JoystickButton4:
                case KeyCode.JoystickButton5:
                case KeyCode.JoystickButton6:
                case KeyCode.JoystickButton7:
                case KeyCode.JoystickButton8:
                case KeyCode.JoystickButton9:
                case KeyCode.JoystickButton10:
                case KeyCode.JoystickButton11:
                case KeyCode.JoystickButton12:
                case KeyCode.JoystickButton13:
                case KeyCode.JoystickButton14:
                case KeyCode.JoystickButton15:
                case KeyCode.JoystickButton16:
                case KeyCode.JoystickButton17:
                case KeyCode.JoystickButton18:
                case KeyCode.JoystickButton19:
                case KeyCode.Joystick1Button0:
                case KeyCode.Joystick1Button1:
                case KeyCode.Joystick1Button2:
                case KeyCode.Joystick1Button3:
                case KeyCode.Joystick1Button4:
                case KeyCode.Joystick1Button5:
                case KeyCode.Joystick1Button6:
                case KeyCode.Joystick1Button7:
                case KeyCode.Joystick1Button8:
                case KeyCode.Joystick1Button9:
                case KeyCode.Joystick1Button10:
                case KeyCode.Joystick1Button11:
                case KeyCode.Joystick1Button12:
                case KeyCode.Joystick1Button13:
                case KeyCode.Joystick1Button14:
                case KeyCode.Joystick1Button15:
                case KeyCode.Joystick1Button16:
                case KeyCode.Joystick1Button17:
                case KeyCode.Joystick1Button18:
                case KeyCode.Joystick1Button19:
                case KeyCode.Joystick2Button0:
                case KeyCode.Joystick2Button1:
                case KeyCode.Joystick2Button2:
                case KeyCode.Joystick2Button3:
                case KeyCode.Joystick2Button4:
                case KeyCode.Joystick2Button5:
                case KeyCode.Joystick2Button6:
                case KeyCode.Joystick2Button7:
                case KeyCode.Joystick2Button8:
                case KeyCode.Joystick2Button9:
                case KeyCode.Joystick2Button10:
                case KeyCode.Joystick2Button11:
                case KeyCode.Joystick2Button12:
                case KeyCode.Joystick2Button13:
                case KeyCode.Joystick2Button14:
                case KeyCode.Joystick2Button15:
                case KeyCode.Joystick2Button16:
                case KeyCode.Joystick2Button17:
                case KeyCode.Joystick2Button18:
                case KeyCode.Joystick2Button19:
                case KeyCode.Joystick3Button0:
                case KeyCode.Joystick3Button1:
                case KeyCode.Joystick3Button2:
                case KeyCode.Joystick3Button3:
                case KeyCode.Joystick3Button4:
                case KeyCode.Joystick3Button5:
                case KeyCode.Joystick3Button6:
                case KeyCode.Joystick3Button7:
                case KeyCode.Joystick3Button8:
                case KeyCode.Joystick3Button9:
                case KeyCode.Joystick3Button10:
                case KeyCode.Joystick3Button11:
                case KeyCode.Joystick3Button12:
                case KeyCode.Joystick3Button13:
                case KeyCode.Joystick3Button14:
                case KeyCode.Joystick3Button15:
                case KeyCode.Joystick3Button16:
                case KeyCode.Joystick3Button17:
                case KeyCode.Joystick3Button18:
                case KeyCode.Joystick3Button19:
                case KeyCode.Joystick4Button0:
                case KeyCode.Joystick4Button1:
                case KeyCode.Joystick4Button2:
                case KeyCode.Joystick4Button3:
                case KeyCode.Joystick4Button4:
                case KeyCode.Joystick4Button5:
                case KeyCode.Joystick4Button6:
                case KeyCode.Joystick4Button7:
                case KeyCode.Joystick4Button8:
                case KeyCode.Joystick4Button9:
                case KeyCode.Joystick4Button10:
                case KeyCode.Joystick4Button11:
                case KeyCode.Joystick4Button12:
                case KeyCode.Joystick4Button13:
                case KeyCode.Joystick4Button14:
                case KeyCode.Joystick4Button15:
                case KeyCode.Joystick4Button16:
                case KeyCode.Joystick4Button17:
                case KeyCode.Joystick4Button18:
                case KeyCode.Joystick4Button19:
                case KeyCode.Joystick5Button0:
                case KeyCode.Joystick5Button1:
                case KeyCode.Joystick5Button2:
                case KeyCode.Joystick5Button3:
                case KeyCode.Joystick5Button4:
                case KeyCode.Joystick5Button5:
                case KeyCode.Joystick5Button6:
                case KeyCode.Joystick5Button7:
                case KeyCode.Joystick5Button8:
                case KeyCode.Joystick5Button9:
                case KeyCode.Joystick5Button10:
                case KeyCode.Joystick5Button11:
                case KeyCode.Joystick5Button12:
                case KeyCode.Joystick5Button13:
                case KeyCode.Joystick5Button14:
                case KeyCode.Joystick5Button15:
                case KeyCode.Joystick5Button16:
                case KeyCode.Joystick5Button17:
                case KeyCode.Joystick5Button18:
                case KeyCode.Joystick5Button19:
                case KeyCode.Joystick6Button0:
                case KeyCode.Joystick6Button1:
                case KeyCode.Joystick6Button2:
                case KeyCode.Joystick6Button3:
                case KeyCode.Joystick6Button4:
                case KeyCode.Joystick6Button5:
                case KeyCode.Joystick6Button6:
                case KeyCode.Joystick6Button7:
                case KeyCode.Joystick6Button8:
                case KeyCode.Joystick6Button9:
                case KeyCode.Joystick6Button10:
                case KeyCode.Joystick6Button11:
                case KeyCode.Joystick6Button12:
                case KeyCode.Joystick6Button13:
                case KeyCode.Joystick6Button14:
                case KeyCode.Joystick6Button15:
                case KeyCode.Joystick6Button16:
                case KeyCode.Joystick6Button17:
                case KeyCode.Joystick6Button18:
                case KeyCode.Joystick6Button19:
                case KeyCode.Joystick7Button0:
                case KeyCode.Joystick7Button1:
                case KeyCode.Joystick7Button2:
                case KeyCode.Joystick7Button3:
                case KeyCode.Joystick7Button4:
                case KeyCode.Joystick7Button5:
                case KeyCode.Joystick7Button6:
                case KeyCode.Joystick7Button7:
                case KeyCode.Joystick7Button8:
                case KeyCode.Joystick7Button9:
                case KeyCode.Joystick7Button10:
                case KeyCode.Joystick7Button11:
                case KeyCode.Joystick7Button12:
                case KeyCode.Joystick7Button13:
                case KeyCode.Joystick7Button14:
                case KeyCode.Joystick7Button15:
                case KeyCode.Joystick7Button16:
                case KeyCode.Joystick7Button17:
                case KeyCode.Joystick7Button18:
                case KeyCode.Joystick7Button19:
                case KeyCode.Joystick8Button0:
                case KeyCode.Joystick8Button1:
                case KeyCode.Joystick8Button2:
                case KeyCode.Joystick8Button3:
                case KeyCode.Joystick8Button4:
                case KeyCode.Joystick8Button5:
                case KeyCode.Joystick8Button6:
                case KeyCode.Joystick8Button7:
                case KeyCode.Joystick8Button8:
                case KeyCode.Joystick8Button9:
                case KeyCode.Joystick8Button10:
                case KeyCode.Joystick8Button11:
                case KeyCode.Joystick8Button12:
                case KeyCode.Joystick8Button13:
                case KeyCode.Joystick8Button14:
                case KeyCode.Joystick8Button15:
                case KeyCode.Joystick8Button16:
                case KeyCode.Joystick8Button17:
                case KeyCode.Joystick8Button18:
                case KeyCode.Joystick8Button19:
                default:
                    throw new ArgumentOutOfRangeException(nameof(key), key, null);
            }
        }

        /// <summary>
        /// To Do: More Than Left, Right & Middle Click Support
        /// </summary>
        /// <param name="button">The Button To Get</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static ButtonControl GetMouseButtonByKeyCode(KeyCode button)
        {
            switch (button)
            {
                case KeyCode.Mouse0:
                    return InputSystem.GetDevice<Mouse>().leftButton;
                case KeyCode.Mouse1:
                    return InputSystem.GetDevice<Mouse>().rightButton;
                case KeyCode.Mouse2:
                    return InputSystem.GetDevice<Mouse>().middleButton;
                case KeyCode.Mouse3:
                case KeyCode.Mouse4:
                case KeyCode.Mouse5:
                case KeyCode.Mouse6:
                default:
                    throw new ArgumentOutOfRangeException(nameof(button), button, null);
            }
        }
    }

}
