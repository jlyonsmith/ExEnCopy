using System;

namespace Microsoft.Xna.Framework.Input
{
	public static class Keyboard
	{
        public static KeyboardState GetState()
        {
            return new KeyboardState();
        }
        
        public static KeyboardState GetState(PlayerIndex playerIndex)
        {
            return new KeyboardState();
        }
    }
}
