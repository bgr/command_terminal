using UnityEngine;

public abstract class TerminalKeyboardInputProvider : MonoBehaviour
{
    public abstract bool GetButtonDown();
    public abstract void SetTerminalOpen(bool open);
}
