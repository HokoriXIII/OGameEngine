using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;

namespace OGameEngine
{
    class Light
    {
        public Light(Vector3 position, Vector3 color, float diffuseintensity = 1.0f, float ambientintensity = 1.0f)
        {
            Position = position;
            Color = color;

            DiffuseIntensity = diffuseintensity;
            AmbientIntensity = ambientintensity;

        }

        GameWindow game = new GameWindow();

        public Vector3 Position;
        public Vector3 Color = new Vector3();
        public float DiffuseIntensity = 1.0f;
        public float AmbientIntensity = 0.1f;

        public Vector3 Direction = new Vector3(0, 0, 0);
    }
}
