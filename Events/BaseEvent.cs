using System.Collections.Generic;
using UnityEngine;

namespace Arekushi.GameEvent
{

    public abstract class BaseEvent<T> : ScriptableObject
	{

        private readonly Dictionary<GameObject, IGameEventListener<T>> listeners =
            new Dictionary<GameObject, IGameEventListener<T>>();

        public void RaiseSpecific(GameObject owner, T item)
		{
            if (listeners.TryGetValue(owner, out IGameEventListener<T> gameEventListener))
			{
                if (gameEventListener != null) listeners[owner].OnEventRaised(item);
            }
        }

        public void RaiseAll(T item)
		{
            foreach(GameObject owner in listeners.Keys)
			{
                if (listeners.TryGetValue(owner, out IGameEventListener<T> gameEventListener))
				{
                    if (gameEventListener != null) listeners[owner].OnEventRaised(item);
                }
            }
        }

        public void RegisterListener(GameObject owner, IGameEventListener<T> listener)
		{
            if(!listeners.ContainsValue(listener))
			{
                listeners[owner] = listener;
            }
        }

        public void UnRegisterListener(GameObject owner, IGameEventListener<T> listener)
		{
            if (listeners.ContainsValue(listener))
			{
                listeners[owner] = null;
            }
        }
    }
	
}
