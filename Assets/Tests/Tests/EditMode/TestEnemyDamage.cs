using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestEnemyDamage
{
    [Test]
    public void TestEnemyDamageNotNegative()
    {
        var gameObject = new GameObject();
        var testerDamage = gameObject.AddComponent<EnemyInteraction>()._enemyDamage;
        bool chek = false;
        if (testerDamage < 0) chek = false;
        else chek = true;

        Assert.IsTrue(chek);

    }

}
