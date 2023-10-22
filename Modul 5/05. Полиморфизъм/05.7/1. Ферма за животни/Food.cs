namespace _1._Ферма_за_животни {
    public abstract class Food {

        public int Quantity { get; protected set; }

        protected Food(int quantity) {
            Quantity = quantity;
        }
    }
}
