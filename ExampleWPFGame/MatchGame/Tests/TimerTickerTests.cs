﻿using MatchGame.GameCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchGame.Tests
{
    public class TimerTickerTests
    {
        private GameTimer gameTimerObj;

        [SetUp]
        public void setup()
        {
            gameTimerObj = new GameTimer();
        }

        [Test]
        public void creationOfTimerTickeObjTest()
        {
            Assert.NotNull(gameTimerObj);
        }
    }
}