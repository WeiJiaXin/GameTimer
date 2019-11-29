using System;
using GameTimer;
using UnityEngine;

public class TimerMono : MonoBehaviour
{
    public bool useTimeScale=true;

    private void Start()
    {
        print(Time.frameCount);
        Timer.Start(0).onEnd += t => print(Time.frameCount);
        var handle = Timer.Start(1);
        handle.loopCount = -1;
        handle.onLoop += (t, i) => print(Time.frameCount);
    }

    private void LateUpdate()
    {
        Timer.Update(useTimeScale ? Time.deltaTime : Time.unscaledDeltaTime);
    }
}