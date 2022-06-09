using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class DirectionTest
{
    [Test]
    public void CheckSpeedChar()
    {
        var gameobject = new GameObject();
        float _speedTester = gameobject.AddComponent<PlayerController_script>()._speed;
        Assert.AreEqual(20,_speedTester);
    }

   
 
}
