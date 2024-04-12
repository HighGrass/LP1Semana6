using System;

namespace BetterColorSpheres

{
    class Sphere
    {
        private Color Cor { get; }
        private float Raio { get; set; }
        private int HitTimes { get; set; }

        public Sphere(Color color, float r)
        {
            Cor = color;
            Raio = r;
        }

        public void Pop() => Raio = 0;
        public void Throw()
        {
            if (Raio > 0) HitTimes++;
        }
        public int GetTimesThrow()
        {
            return HitTimes;
        }
        public Color GetColor()
        {
            return Cor;
        }
        public float GetRadius()
        {
            return Raio;
        }

    }
}