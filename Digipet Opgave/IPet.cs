namespace Digipet_Opgave
{
    interface IPet
    {
        public void ClampValues();
        public void Train();
        public void Feed();
        public void Play();
        public void Sleep();
        public void Fight(Monster monster);
        public void Print();
        public void Update(Object? obj);

    }
}
