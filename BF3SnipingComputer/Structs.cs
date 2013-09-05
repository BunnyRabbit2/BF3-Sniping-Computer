namespace BF3SnipingComputer
{
    struct Weapon
    {
        public string name;
        public int velocity;
        public float gravity;
        public float timeToLive;
        public int sVelocity;
        public int hbVelocity;
    }

    struct Sight
    {
        public string name;
        public float origMil;
        public int origPixels;
        public float a, b, c;
    }
}