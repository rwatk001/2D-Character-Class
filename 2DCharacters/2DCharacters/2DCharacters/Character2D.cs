using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace _2DCharacters
{
    class Character2D
    {
        private Dictionary<String, AnimatedSprite> SpriteSheets;

        public Character2D() { }

        public Character2D(Dictionary<String, AnimatedSprite> spriteSheets)
        {
            SpriteSheets = spriteSheets;
        }

        public void AddSpriteSheet(String spriteState, AnimatedSprite spriteSheet)
        {
            SpriteSheets.Add(spriteState, spriteSheet);
        }
    }
}
