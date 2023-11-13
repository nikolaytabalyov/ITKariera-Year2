namespace CryptoMiningSystem {
    public class Computer {
		private Processor _processor;
		private VideoCard _videoCard;
		private int _ram;
		private double _minedAmountPerHour;

		public Processor Processor {
			get { return _processor; }
			set { _processor = value; }
		}
		public VideoCard VideoCard {
			get { return _videoCard; }
			set { _videoCard = value; }
		}
		public int Ram {
			get { return _ram; }
			set {
				if (value <= 0 || value > 32)
					throw new ArgumentException("PC Ram cannot be less or equal to 0 and more than 32!");
				_ram = value; 
			}
		}
		public double MinedAmountPerHour {
			get { return _minedAmountPerHour; }
			set { _minedAmountPerHour = value; } // TODO:
		}
	}
}