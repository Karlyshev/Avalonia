﻿namespace Perspex.Media
{
    /// <summary>
    /// GradientStop
    /// </summary>
    public sealed class GradientStop
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GradientStop"/> class.
        /// </summary>
        public GradientStop() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="GradientStop"/> class.
        /// </summary>
        /// <param name="color">The color</param>
        /// <param name="offset">The offset</param>
        public GradientStop(Color color, double offset)
        {
            this.Color = color;
            this.Offset = offset;
        }

        // TODO: Make these dependency properties.

        /// <summary>
        /// The offset
        /// </summary>
        public double Offset { get; set; }

        /// <summary>
        /// The color
        /// </summary>
        public Color Color { get; set; }
    }
}