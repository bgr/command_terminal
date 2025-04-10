using UnityEngine;

namespace CommandTerminal
{
    public class TerminalKeyboardInputProviderMock : TerminalKeyboardInputProvider
    {
        public override bool GetButtonDown() => Input.GetKeyDown(KeyCode.BackQuote);

        public override void SetTerminalOpen(bool open) { }
    }
}