using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arekushi.GameEvent
{
    public interface IGameEventListener<T>
	{
        void OnEventRaised(T item);
    }
}
