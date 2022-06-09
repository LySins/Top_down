using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CheckHealthPlayer
{
    // A Test behaves as an ordinary method
    [Test]
    public void CheckHealthPlayerSimplePasses()
    {
        var gameObject = new GameObject();
        int testHealthPlayer = gameObject.AddComponent<PlayerInteraction>()._healthPlayer;
        bool cheker = false;
        if (testHealthPlayer != 0) cheker = true;
        else cheker = false;

        Assert.IsTrue(cheker);
    }
}
