﻿#region File Description
//-----------------------------------------------------------------------------
// Obstacle.cs
//
// Written by Thomas
// Last Updated: 2016-09-13
//-----------------------------------------------------------------------------
#endregion

#region Using Statements
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TGExtensions;
using TGGameLibrary.Enums;
#endregion

namespace TGGameLibrary
{
    public class Obstacle : MoveableSprite
    {
        #region Initialisation
        public Obstacle(Game game, Rectangle footprint, int height, float? movementSpeed = 0.0F, Face? facing = Face.Down, float? scale = 1.0F)
            : base(game, 1, null, footprint, movementSpeed, facing, scale)
        {
            Geometry = new Rectangle(footprint.X, footprint.Y - height, footprint.Width, footprint.Height + height);
            FootprintGeometry = new Rectangle(0, height, footprint.Width, footprint.Height);
        }
        #endregion

        #region MonoGame Default Methods
        public override void Draw(SpriteBatch spriteBatch)
        {
            this.Draw(spriteBatch, Color.Black, Depth);
        }

        public override void Draw(SpriteBatch spriteBatch, Color color)
        {
            this.Draw(spriteBatch, color, Depth);
        }

        public override void Draw(SpriteBatch spriteBatch, Color color, float depth)
        {
            spriteBatch.Draw(DummyTexture, null, Geometry, null, Vector2.Zero, 0.0F, null, color, SpriteEffects.None, depth > 0 ? depth : 0.0F.NextAfter());
        }
        #endregion
    }
}
