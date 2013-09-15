﻿using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xunit;
using PocketSharp.Models;

namespace PocketSharp.Tests
{
  public class TestsBase : IDisposable
  {
    protected PocketClient client;


    // setup
    public TestsBase()
    {
      // !! please don't misuse this account !!
      client = new PocketClient(
        consumerKey: "15396-f6f92101d72c8e270a6c9bb3",
        callbackUri: "http://frontendplay.com",
        accessCode: "2c62cd50-b78a-5558-918b-65adae"
      );
    }


    // teardown
    public void Dispose()
    {

    }
  }
}
