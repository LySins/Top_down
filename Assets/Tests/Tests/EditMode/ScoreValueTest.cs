using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ScoreValueTest
{
    [Test]
    public void ScoreValueTestSimplePasses()
    {
        var gameObject = new GameObject();
        int testScore = gameObject.AddComponent<ScoreImage>()._score;
        Assert.AreNotEqual(-1, testScore);
    }

}
