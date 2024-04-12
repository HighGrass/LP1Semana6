using System;

namespace ColorSpheres

{
    class Sphere
    {
        private readonly Color cor;
        float raio;
        int hit_times;

        public Sphere(Color color, float r)
        {
            cor = color;
            raio = r;
        }

        public void Pop() => raio = 0;
        public void Throw()
        {
            if (raio > 0) hit_times++;
        }
        public int GetTimesThrow() {
            return hit_times;
        }
        public Color GetColor(){
            return cor;
        }
        public float GetRadius(){
            return raio;
        }
        
    }
}