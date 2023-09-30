namespace _5 {
    class EvenNumber {

        private int num;

        public int Num {
            get => num;
            set {
                if (value % 2 == 0)
                    num = value;
            }
        }

        public EvenNumber(int num) {
            Num = num;
        }
    }
}
