using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMiningSystem.Entities.Contracts {
    public interface IUser {
        string Name { get; }
        int Stars { get; }
        decimal Money { get; }
        Computer Computer{ get; }
    }
}
