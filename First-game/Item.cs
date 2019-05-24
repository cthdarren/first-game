namespace First_game
{
    public struct Item
    {
        public string _name;
        public int _price, _health, _atk;
        public bool _isweapon;

        public Item(string name, int price, int hp, int atk, bool iswep)
        {
            _name = name;
            _price = price;
            _health = hp;
            _atk = atk;
            _isweapon = iswep;
        }
    }
}