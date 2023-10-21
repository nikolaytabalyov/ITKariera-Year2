namespace _1._Животинско_царство_2 {
    public class Trainer {
        private IAnimal _entity;

        public Trainer(IAnimal entity) {
            _entity = entity;
        }

        public void Make() => _entity.Perform();
    }
}
