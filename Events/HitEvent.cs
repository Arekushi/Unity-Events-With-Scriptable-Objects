using UnityEngine;

namespace Arekushi.GameEvent
{

    public class HitData
	{

        public GameObject aggressor;
        public GameObject victim;
        public int damage;

        public HitData(GameObject aggressor, GameObject victim, int damage)
		{
            this.aggressor = aggressor;
            this.victim = victim;
            this.damage = damage;
        }
    }

    [CreateAssetMenu(menuName = "Characters/Events/Hit Event")]
    public class HitEvent : BaseEvent<HitData> { }
}
