using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GeneralFunctionTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void EnemyCoolDownTest()
    {
        var gameObject = new GameObject();
        float tester = gameObject.AddComponent<EnemyRespawn>()._EnemyCD;
        Assert.AreEqual(1, tester);
    }

}
