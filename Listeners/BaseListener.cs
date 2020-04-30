using UnityEngine;
using UnityEngine.Events;

namespace Arekushi.GameEvent
{

    public abstract class BaseListener<T, E, UER> : MonoBehaviour, IGameEventListener<T>
        where E : BaseEvent<T> where UER : UnityEvent<T>
		{

        [SerializeField]
        private E gameEvent;

        [SerializeField]
        private UER unityEventResponse;

        private void OnEnable()
		{
            if (gameEvent != null)
                gameEvent.RegisterListener(gameObject, this);
        }

        private void OnDisable()
		{
            if (gameEvent != null)
                gameEvent.UnRegisterListener(gameObject, this);
        }

        public void OnEventRaised(T item)
		{
            if(unityEventResponse != null)
                unityEventResponse.Invoke(item);
        }

    }
}
