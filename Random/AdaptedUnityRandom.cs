using UnityEngine;

namespace UnityToolbag
{
    public class AdaptedUnityRandom : ICreateRandom
    {
        public int Seed
        {
            get { return Random.seed; }
            set { Random.seed = value; }
        }
        
        public float Next()
        {
            return Random.value;
        }

        public float Next(float max)
        {
            return Random.value * max;
        }

        public float Next(float min, float max)
        {
            return Random.Range(min, max);
        }

        public int Next(int min, int max)
        {
            return Random.Range(min, max);
        }

        public int Next(int max)
        {
            return Random.Range(0, max);
        }
    }
}