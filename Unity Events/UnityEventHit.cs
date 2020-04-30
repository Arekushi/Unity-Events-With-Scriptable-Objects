using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Arekushi.GameEvent
{
    [Serializable]
    public class HitUnityEvent : UnityEvent<HitData> { }
}
